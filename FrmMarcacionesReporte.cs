using MD.Cto;
using MD.Entidades;
using MD.Repositorios;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD
{
    public partial class FrmMarcacionesReporte : Form
    {

        Repositorios.RepositorioMarcaciones repoMarcaciones = new RepositorioMarcaciones();
        RepositorioJustificaciones repoJusticaciones = new RepositorioJustificaciones();
        public FrmMarcacionesReporte()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListaMarcacionesReporte();
        }


        private void CargarSucursales()
        {
            List<Sucursal> sucursales;
            using (MdDbContext db = new MdDbContext())
            {

                sucursales = db.Sucursales.Where(x => x.IsActivo).ToList();
            }

            cboSucursales.ValueMember = "CodigoSucursal";
            cboSucursales.DisplayMember = "Nombre";
            cboSucursales.DataSource = sucursales;
        }

        private void FrmMarcacionesReporte_Load(object sender, EventArgs e)
        {
            this.lswDatosMarcaciones.Columns.Add("CodigoEmpleado", 100);
            this.lswDatosMarcaciones.Columns.Add("NombreEmpleado", 250);
            this.lswDatosMarcaciones.Columns.Add("CodigoSucursal", 100);
            this.lswDatosMarcaciones.Columns.Add("Sucursal", 100);
            this.lswDatosMarcaciones.Columns.Add("Fecha", 100);
            this.lswDatosMarcaciones.Columns.Add("Entrada", 150);
            this.lswDatosMarcaciones.Columns.Add("Salida", 150);
            this.lswDatosMarcaciones.Columns.Add("Horas_Reglamentarias", 100);
            this.lswDatosMarcaciones.Columns.Add("Horas_Marcadas", 100);
            this.lswDatosMarcaciones.Columns.Add("Horas_En_Contra", 100);
            this.lswDatosMarcaciones.Columns.Add("Horas_En_Favor", 100);
            this.lswDatosMarcaciones.Columns.Add("Horas_Justificadas", 100);
            this.lswDatosMarcaciones.Columns.Add("Total_Horas", 100);

            CargarSucursales();
        }


        private void ListaMarcacionesReporte()
        {
            try
            {
                this.lswDatosMarcaciones.Items.Clear();

                IEnumerable<CtoMarcacionesReporte> marcaciones;

                SqlParameter fechaInicial = new SqlParameter("@FechaIni", this.dtpFechaInicio.Value.ToString("yyyy/MM/dd"));
                SqlParameter fechaFinal = new SqlParameter("@FechaFin", this.dtpFechaFin.Value.ToString("yyyy/MM/dd"));
                SqlParameter slike = new SqlParameter("@sLike", this.txtBusqueda.Text);
                SqlParameter codigoSucursal = new SqlParameter("@codigoSucursal", ((Sucursal)this.cboSucursales.SelectedItem).CodigoSucursal);


                using (MdDbContext db = new MdDbContext())
                {
                    marcaciones = db.CtoMarcacionesReporte.FromSqlRaw<CtoMarcacionesReporte>(@"EXEC SP_Marcaciones @FechaIni,@FechaFin,@sLike,@CodigoSucursal", fechaInicial, fechaFinal, slike, codigoSucursal)
                        .ToList();
                }

                foreach (CtoMarcacionesReporte e in marcaciones)
                {

                    ListViewItem lista = new ListViewItem(e.CodigoEmpleado.ToString());
                    lista.SubItems.Add(e.NombreEmpleado);
                    lista.SubItems.Add(e.CodigoSucursal.ToString());
                    lista.SubItems.Add(e.Sucursal);
                    lista.SubItems.Add(e.Fecha.ToString("yyyy/MM/dd"));
                    lista.SubItems.Add(e.Entrada == null ? "" : e.Entrada.Value.ToString("yyyy/MM/dd hh:mm:ss"));
                    lista.SubItems.Add(e.Salida == null ? "" : e.Salida.Value.ToString("yyyy/MM/dd hh:mm:ss"));

                    lista.SubItems.Add(e.HorasReglamentarias.ToString());
                    lista.SubItems.Add(e.HorasMarcadas.ToString());
                    lista.SubItems.Add(e.TiempoEnContra.ToString());
                    lista.SubItems.Add(e.TiempoAFavor.ToString());
                    lista.SubItems.Add(e.HorasJustificadas.ToString());
                    lista.SubItems.Add(e.CantidadHorasFinal.ToString());



                    this.lswDatosMarcaciones.Items.Add(lista);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListaMarcaciones()
        {
            try
            {
                this.lswDatosMarcaciones.Items.Clear();

                IEnumerable<Marcacion> marcaciones;
                using (MdDbContext db = new MdDbContext())
                {
                    marcaciones = db.Marcaciones
                        .Include(x => x.Sucursal)
                        .Include(e => e.Empleado)
                        .Where(x => x.Fecha.Date >= this.dtpFechaInicio.Value.Date && x.Fecha.Date <= this.dtpFechaFin.Value.Date && x.Empleado.NombreEmpleado.Contains(txtBusqueda.Text)).ToList();
                }

                foreach (Marcacion e in marcaciones)
                {

                    ListViewItem lista = new ListViewItem(e.IdMarcacion.ToString());
                    lista.SubItems.Add(e.Sucursal.Nombre);
                    lista.SubItems.Add(e.CodigoEmpleado.ToString());
                    lista.SubItems.Add(e.Empleado.NombreEmpleado);
                    lista.SubItems.Add(e.Empleado.Cedula);
                    lista.SubItems.Add(e.Fecha.ToString("yyyy/MM/dd hh:mm:ss"));
                    lista.SubItems.Add(e.Empleado.IsActivo.ToString());

                    this.lswDatosMarcaciones.Items.Add(lista);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lswDatosMarcaciones.Items.Clear();

            if (this.txtBusqueda.Text.Length > 3)
            {
                ListaMarcacionesReporte();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Marcacion> listMarcacion = new List<Marcacion>();
                    List<Justificacion> listJustificaciones = new List<Justificacion>();
                    openFileDialog1.Multiselect = true;

                    string ruta = openFileDialog1.FileName.Replace(openFileDialog1.SafeFileName, "");
                    string[] files = Directory.GetFiles(ruta).Where(x => x.Contains(".csv")).ToArray();

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
                                        Fecha = DateTime.Parse(fields[1].ToString()),
                                        CodigoEmpleado = int.Parse(fields[2].ToString()),
                                        CodigoSucursal = int.Parse(fields[3].ToString())
                                    });
                                }
                                if (item.Contains("TH-manager-import-justifi-"))
                                {
                                    listJustificaciones.Add(new Justificacion
                                    {
                                        CodigoEmpleado = int.Parse(fields[1].ToString()),
                                        Observacion = fields[2].ToString(),
                                        CodigoTipoJustificacion = int.Parse(fields[3].ToString()),
                                        HoraInicial = DateTime.Parse(fields[4].ToString()),
                                        HoraFinal = DateTime.Parse(fields[5].ToString()),
                                        Horas = int.Parse(fields[8].ToString()),
                                        IsFeriado = false,
                                        CodigoEstado = int.Parse(fields[10].ToString()),
                                        IsEliminado = false,
                                        CodigoUsuarioCreacion = 1,
                                        FechaCreacion = DateTime.Parse(fields[13].ToString())

                                    });
                                }
                            }
                        }
                    }
                    if (listMarcacion.Count == 0 && listJustificaciones.Count == 0) {
                        MessageBox.Show("No existen datos para importar", "Importacion de Datos");
                        return;
                    }

                    if (MessageBox.Show($"Seguro que desea importar estos datos? {Environment.NewLine} Se importaran {listMarcacion.Count} Marcaciones y {listJustificaciones.Count} Justificaciones", "Importacion de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        if (listMarcacion.Count > 0)
                        {

                            repoMarcaciones.ImportarMarcaciones(listMarcacion);
                            repoJusticaciones.ImportarJustificacion(listJustificaciones);

                        }
                        MessageBox.Show("La informacion se importo correctamente");
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }


        }
    }
}
