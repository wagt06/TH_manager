using MD.Cto;
using MD.Entidades;
using MD.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD
{
    public partial class FrmGestionDatos : Form
    {
        Repositorios.RepositorioJustificaciones repoJustificaciones = new Repositorios.RepositorioJustificaciones();
        Repositorios.RepositorioMarcaciones repositorioMarcaciones = new Repositorios.RepositorioMarcaciones();
        public FrmGestionDatos()
        {
            InitializeComponent();
        }

        private void FrmGestionDatos_Load(object sender, EventArgs e)
        {
            List<Sucursal> sucursales;
            using (MdDbContext db = new MdDbContext())
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


        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            List<Marcacion> marcaciones = new List<Marcacion>();
            List<Justificacion> justificaciones = new List<Justificacion>();
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
                List<Cto.MarcacionesExport> marcacionesExport = marcaciones.Select(x => new MarcacionesExport { CodigoEmpleado = x.CodigoEmpleado, Fecha = x.Fecha, IdMarcacion = x.IdMarcacion }).ToList();
                string archivo = "\\TH-manager-import-marca-" + DateTime.Now.ToString("yyyyMMdd hhmmss") + ".csv";
                SaveToCsv(marcacionesExport, path + archivo);

                ListViewItem lista = new ListViewItem(archivo);
                lista.SubItems.Add(marcacionesExport.Count.ToString());
                this.lvwDocumentos.Items.Add(lista);

            }

            if (this.chkJustificaciones.Checked)
            {
                justificaciones = repoJustificaciones.JustificacionesPorFecha(dtpFechaInicio.Value, dtpFechaFin.Value, ((Sucursal)cboSucursales.SelectedItem).CodigoSucursal);
                List<JustificacionesExport> justificacionesExports = justificaciones.Select(x => new JustificacionesExport
                {
                    CodigoEmpleado = x.CodigoEmpleado
                    ,
                    CodigoEstado = x.CodigoEstado
                    ,
                    CodigoTipoJustificacion = x.CodigoTipoJustificacion
                    ,
                    Fecha = x.Fecha
                    ,
                    HoraInicial = x.HoraInicial
                    ,
                    HoraFinal = x.HoraFinal
                    ,
                    Horas = x.Horas
                    ,
                    IsEliminado = x.IsEliminado
                    ,
                    IsFeriado = x.IsFeriado
                    ,
                    IsPermiso = x.IsPermiso
                    ,
                    FechaCreacion = x.FechaCreacion
                    ,
                    CodigoUsuarioCreacion = x.CodigoUsuarioCreacion
                }).ToList();

                string archivo = "\\TH-manager-import-justifi-" + DateTime.Now.ToString("yyyyMMdd hhmmss") + ".csv";
                SaveToCsv(justificaciones, path + archivo);
                ListViewItem lista = new ListViewItem(archivo);
                lista.SubItems.Add(justificaciones.Count.ToString());
                this.lvwDocumentos.Items.Add(lista);
            }

            Process.Start("explorer.exe", path);
            MessageBox.Show("Se exportaron los datos correctamente!");
        }

        private void SaveToCsv<T>(List<T> reportData, string path)
        {
            try
            {
                if (reportData.Count > 0)
                {
                    var lines = new List<string>();
                    IEnumerable<PropertyDescriptor> props = TypeDescriptor.GetProperties(typeof(T)).OfType<PropertyDescriptor>();
                    var header = string.Join(",", props.ToList().Select(x => x.Name));
                    lines.Add(header);
                    var valueLines = reportData.Select(row => string.Join(",", header.Split(',').Select(a => row.GetType().GetProperty(a).GetValue(row, null))));
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
