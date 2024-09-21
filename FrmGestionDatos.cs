using MD.Cto;
using MD.Entidades;
using MD.Repositorios;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD
{


    public partial class FrmGestionDatos : Form
    {
        Repositorios.RepositorioJustificaciones repoJustificaciones = new Repositorios.RepositorioJustificaciones();
        Repositorios.RepositorioMarcaciones repositorioMarcaciones = new Repositorios.RepositorioMarcaciones();

        List<Marcacion> marcaciones = new List<Marcacion>();
        List<Justificacion> justificaciones = new List<Justificacion>();
        public FrmGestionDatos()
        {
            InitializeComponent();
        }

        private void FrmGestionDatos_Load(object sender, EventArgs e)
        {
            List<Sucursal> sucursales;
            using (DbContext db = new DbContext())
            {

                sucursales = db.Sucursales.Where(x => x.IsActivo).ToList();
            }

            cboSucursales.ValueMember = "CodigoSucursal";
            cboSucursales.DisplayMember = "Nombre";
            cboSucursales.DataSource = sucursales;

            this.lvwDocumentos.Columns.Add("Archivo", 250);
            this.lvwDocumentos.Columns.Add("Items", 100);
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
            }
            else
                return;

            try
            {
                List<Marcacion> listMarcacion = new List<Marcacion>();
                List<Justificacion> listJustificaciones = new List<Justificacion>();
                int numMarcasImportada = 0;
                int numJustImportada = 0;

                string[] files = Directory.GetFiles(path).Where(x => x.Contains(".csv")).ToArray();

                foreach (var item in files)
                {

                    using (TextFieldParser csvReader = new TextFieldParser(item))
                    {
                        csvReader.CommentTokens = new string[] { "#" };
                        csvReader.SetDelimiters(new string[] { ";" });
                        csvReader.HasFieldsEnclosedInQuotes = true;

                        // Skip the row with the column names
                        csvReader.ReadLine();
                        while (!csvReader.EndOfData)
                        {
                            // Read current line fields, pointer moves to the next line.
                            string[] fields = csvReader.ReadFields();

                            if (item.Contains("TH-manager-import-marca-"))
                            {
                                listMarcacion.Add(new Marcacion
                                {

                                    CodigoEmpleado = int.Parse(fields[0].ToString()),
                                    Fecha = DateTime.Parse(fields[1].ToString()),
                                    CodigoSucursal = int.Parse(fields[2].ToString())
                                });
                            }

                            if (item.Contains("TH-manager-import-justifi-"))
                            {
                                listJustificaciones.Add(new Justificacion
                                {
                                    CodigoEmpleado = int.Parse(fields[0].ToString()),
                                    Observacion = fields[1].ToString(),
                                    CodigoTipoJustificacion = int.Parse(fields[2].ToString()),
                                    Fecha = DateTime.Parse(fields[3].ToString()),
                                    HoraInicial = DateTime.Parse(fields[4].ToString()),
                                    HoraFinal = DateTime.Parse(fields[5].ToString()),
                                    Horas = int.Parse(fields[6].ToString()),
                                    IsFeriado = false,
                                    CodigoEstado = int.Parse(fields[7].ToString()),
                                    IsEliminado = false,
                                    CodigoUsuarioCreacion = 1,
                                    FechaCreacion = DateTime.Parse(fields[8].ToString())

                                });
                            }
                        }
                    }
                }
                if (listMarcacion.Count == 0 && listJustificaciones.Count == 0)
                {
                    MessageBox.Show("No existen datos para importar", "Importacion de Datos");
                    return;
                }

                if (MessageBox.Show($"Seguro que desea importar estos datos? {Environment.NewLine} Se importaran {listMarcacion.Count} Marcaciones y {listJustificaciones.Count} Justificaciones", "Importacion de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (listMarcacion.Count > 0)
                    {

                        numMarcasImportada = repositorioMarcaciones.ImportarMarcaciones(listMarcacion);
                        numJustImportada = repoJustificaciones.ImportarJustificacion(listJustificaciones);

                    }
                    InsertarLvw("Marcaciones", numMarcasImportada.ToString());
                    InsertarLvw("Justificaciones", numJustImportada.ToString());

                    MessageBox.Show("La informacion se importo correctamente");
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

            this.lvwDocumentos.Items.Clear();
            string path = string.Empty;


            if (MessageBox.Show("Se procedera a exportar los datos en el rango de fecha seleccionado, este proceso podria dilatar unos segundos." + Environment.NewLine + "Seguro que desea seguir con el proceso?", "Exportacion de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
            }
            else
                return;


            if (this.chkMarcaciones.Checked)
            {

                marcaciones = repositorioMarcaciones.MarcacionesPorFecha(dtpFechaInicio.Value, dtpFechaFin.Value, ((Sucursal)cboSucursales.SelectedItem).CodigoSucursal);
                List<Cto.MarcacionesExport> marcacionesExport = marcaciones.Select(x => new MarcacionesExport { CodigoEmpleado = x.CodigoEmpleado, Fecha = x.Fecha, CodigoSucursal = x.CodigoSucursal }).ToList();
                string archivo = "\\TH-manager-import-marca-" + DateTime.Now.ToString("yyyyMMdd hhmmss") + ".csv";
                SaveToCsv(marcacionesExport, path + archivo);

                InsertarLvw(archivo, marcacionesExport.Count.ToString());

            }

            if (this.chkJustificaciones.Checked)
            {
                justificaciones = repoJustificaciones.JustificacionesPorFecha(dtpFechaInicio.Value, dtpFechaFin.Value, ((Sucursal)cboSucursales.SelectedItem).CodigoSucursal);
                List<JustificacionesExport> justificacionesExports = justificaciones.Select(x => new JustificacionesExport
                {
                    CodigoEmpleado = x.CodigoEmpleado,
                    CodigoEstado = x.CodigoEstado,
                    Observacion = x.Observacion,
                    CodigoTipoJustificacion = x.CodigoTipoJustificacion,
                    Fecha = x.Fecha,
                    HoraInicial = x.HoraInicial,
                    HoraFinal = x.HoraFinal,
                    Horas = x.Horas,
                    FechaCreacion = x.FechaCreacion
                }).ToList();

                string archivo = "\\TH-manager-import-justifi-" + DateTime.Now.ToString("yyyyMMdd hhmmss") + ".csv";
                SaveToCsv(justificacionesExports, path + archivo);

                InsertarLvw(archivo, justificacionesExports.Count.ToString());

            }

            Process.Start("explorer.exe", path);
            MessageBox.Show("Se exportaron los datos correctamente!");
        }

        private void InsertarLvw(string nombre, string valor)
        {
            ListViewItem lista = new ListViewItem(nombre);
            lista.SubItems.Add(valor);
            this.lvwDocumentos.Items.Add(lista);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void SaveToCsv<T>(List<T> reportData, string path)
        {
            try
            {
                if (reportData.Count > 0)
                {
                    var lines = new List<string>();
                    IEnumerable<PropertyDescriptor> props = TypeDescriptor.GetProperties(typeof(T)).OfType<PropertyDescriptor>();
                    var header = string.Join(";", props.ToList().Select(x => x.Name));
                    lines.Add(header);
                    var valueLines = reportData.Select(row => string.Join(";", header.Split(';').Select(a => row.GetType().GetProperty(a).GetValue(row, null))));
                    lines.AddRange(valueLines);
                    File.WriteAllLines(path, lines.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
