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
using System.Formats.Asn1;
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
            using (DbContext db = new DbContext())
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

            dtpFechaInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
            dtpFechaFin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 1, 0, 0, 0).AddDays(-1);

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


                using (DbContext db = new DbContext())
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
                using (DbContext db = new DbContext())
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
            FrmGestionDatos frm = new FrmGestionDatos();
            frm.ShowDialog();

            return;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Tools.Tool.CopyListBox(this.lswDatosMarcaciones);
        }

        

        private void lswDatosMarcaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lswDatosMarcaciones_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lswDatosMarcaciones.Sorting = lswDatosMarcaciones.Sorting == System.Windows.Forms.SortOrder.Ascending ? System.Windows.Forms.SortOrder.Descending : System.Windows.Forms.SortOrder.Ascending;
        }
    }
}
