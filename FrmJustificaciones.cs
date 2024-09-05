using MD.Cto;
using MD.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD
{
    public partial class FrmJustificaciones : Form
    {
        Repositorios.RepositorioEmpleados repositorioEmpleados = new Repositorios.RepositorioEmpleados();
        Repositorios.RepositorioJustificaciones repositorioJustificaciones = new Repositorios.RepositorioJustificaciones();
        IEnumerable<CtoJustificacion> JustificacionesLista;
        public FrmJustificaciones()
        {
            InitializeComponent();
        }
        private void FrmJustificaciones_Load(object sender, EventArgs e)
        {

            CargarDatos();

            this.lwsJustificaciones.Columns.Clear();
            this.lwsJustificaciones.Columns.Add("Num.Doc", 100);
            this.lwsJustificaciones.Columns.Add("Nombre", 250);
            this.lwsJustificaciones.Columns.Add("Justificacion", 250);
            this.lwsJustificaciones.Columns.Add("Estado", 200);
            this.lwsJustificaciones.Columns.Add("Fecha", 150);
            this.lwsJustificaciones.Columns.Add("Inicio", 150);
            this.lwsJustificaciones.Columns.Add("Fin", 150);
            this.lwsJustificaciones.Columns.Add("Horas", 150);

            this.CalendarDias.MaxSelectionCount = 31;
            this.dtpFechaInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            this.dtpFechaFinal.Value = DateTime.Now.AddDays(10);
        }
        private void CargarJustificaciones()
        {
            this.lwsJustificaciones.Items.Clear();

            FiltroBusqueda filtro = new FiltroBusqueda
            {
                FechaInicial = dtpFechaInicial.Value
                ,
                FechaFinal = dtpFechaFinal.Value
                ,
                IsPendiente = ChkPendientes.Checked
            };

            JustificacionesLista = repositorioJustificaciones.CtoJustificacionLista(filtro);

            if (chkSoloEmpleado.Checked && !string.IsNullOrEmpty(TxtIdEmpleado.Text))
            {
                JustificacionesLista = JustificacionesLista.Where(x => x.CodigoEmpleado == int.Parse(TxtIdEmpleado.Text));
            }

            foreach (CtoJustificacion item in JustificacionesLista)
            {
                ListViewItem lista = new ListViewItem(item.CodigoJustificacion.ToString());
                lista.SubItems.Add($"({item.CodigoEmpleado.ToString()}) {item.NombreEmpleado}");
                lista.SubItems.Add(item.TipoJustificacion);
                lista.SubItems.Add(item.Estado);
                lista.SubItems.Add(item.Fecha.ToString("yyyy/MM/dd"));
                lista.SubItems.Add(item.HoraInicio.ToString("hh:mm:ss"));
                lista.SubItems.Add(item.HoraFin.ToString("hh:mm:ss"));
                lista.SubItems.Add(item.Horas.ToString());

                lista.SubItems[3].ForeColor = item.CodigoEstado == 1 ? Color.LightGoldenrodYellow : Color.Red;
                this.lwsJustificaciones.Items.Add(lista);
            }
        }
        private void CargarDatos()
        {
            cboTipoJustificaciones.ValueMember = "CodigoTipoJustificacion";
            cboTipoJustificaciones.DisplayMember = "Descripcion";

            cboEstadoJustificaciones.ValueMember = "CodigoEstadoJustificacion";
            cboEstadoJustificaciones.DisplayMember = "Descripcion";


            this.cboEstadoJustificaciones.DataSource = repositorioJustificaciones.ListaEstadoJustificaciones();
        }
        private void CalcularHorasJustificadas()
        {

            //validar que los inicial no sea mayor a la final.
            //if (dtpInicio.Value > dtpFin.Value)
            //{
            //    MessageBox.Show("revise que las fechas sean validas ");
            //    return;
            //}
            decimal horas = (dtpFin.Value - dtpInicio.Value).Hours;
            decimal minutos = (dtpFin.Value - dtpInicio.Value).Minutes;
            this.txtHoras.Text = (minutos > 0 ? horas + (minutos / 60): horas).ToString();
        }
        private void DtpInicio_ValueChanged(object sender, EventArgs e)
        {
            CalcularHorasJustificadas();
        }
        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            CalcularHorasJustificadas();

        }
        private void GuardaJustficaciones(DateTime fecha)
        {
            repositorioJustificaciones.GuardarJustificacion(new Justificacion
            {
                CodigoJustificacion = int.Parse(string.IsNullOrEmpty(this.txtCodigoJustificacion.Text)?"0": this.txtCodigoJustificacion.Text),
                CodigoEmpleado = int.Parse(TxtIdEmpleado.Text),
                CodigoTipoJustificacion = ((TipoJustificacion)cboTipoJustificaciones.SelectedItem).CodigoTipoJustificacion,
                CodigoEstado = ((Estados)cboEstadoJustificaciones.SelectedItem).CodigoEstadoJustificacion,
                Fecha = fecha,
                HoraInicial = dtpInicio.Value,
                HoraFinal = dtpFin.Value,
                Horas = decimal.Parse(txtHoras.Text),
                Observacion = txtObservaciones.Text,
                CodigoUsuarioCreacion = 1,
                FechaCreacion = DateTime.Now,
                IsEliminado = false,
                IsFeriado = false
            });
        }
        private void Limpiar()
        {
            txtCodigoJustificacion.Text = "";
            TxtIdEmpleado.Text = "";
            txtNombre.Text = "";
            txtObservaciones.Text = "";
            txtHoras.Text = "";
            cboTipoJustificaciones.SelectedIndex = -1;
            cboEstadoJustificaciones.SelectedIndex = -1;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //if (TxtIdEmpleado.Text.Length == 0)
            //{
            //    MessageBox.Show("busque un Empleado para ver las justificaciones");
            //    return;
            //}

            CargarJustificaciones();
        }
        private void LwsJustificaciones_DoubleClick(object sender, EventArgs e)
        {
            if (this.lwsJustificaciones.Items.Count > 0)
            {

                if (this.lwsJustificaciones.SelectedItems.Count > 0)
                {
                    CtoJustificacion justificacion = JustificacionesLista.FirstOrDefault(x => x.CodigoJustificacion == int.Parse(this.lwsJustificaciones.SelectedItems[0].Text));
                    if (justificacion != null)
                    {

                        if (justificacion.IsPermiso)
                            this.RdPermiso_CheckedChanged(null, null);
                        else
                            this.RdHoraExtra_CheckedChanged(null, null);


                        this.txtCodigoJustificacion.Text = justificacion.CodigoJustificacion.ToString();
                        this.TxtIdEmpleado.Text = justificacion.CodigoEmpleado.ToString();
                        this.txtNombre.Text = justificacion.NombreEmpleado;
                        this.txtObservaciones.Text = justificacion.Observaciones;
                        this.txtHoras.Text = justificacion.Horas.ToString();
                        cboEstadoJustificaciones.SelectedValue = justificacion.CodigoEstado;
                        cboTipoJustificaciones.SelectedValue = justificacion.CodigoTipoJustificacion;
                        CalendarDias.SetDate(justificacion.Fecha);
                        dtpInicio.Value = justificacion.HoraInicio;
                        dtpFin.Value = justificacion.HoraFin;



                    }
                }

            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
        private void RdPermiso_CheckedChanged(object sender, EventArgs e)
        {
            IEnumerable<TipoJustificacion> tipos = repositorioJustificaciones.ListaTipoJustificaciones().Where(x => x.IsSalida).ToList();
            this.cboTipoJustificaciones.DataSource = tipos;
        }
        private void RdHoraExtra_CheckedChanged(object sender, EventArgs e)
        {
            IEnumerable<TipoJustificacion> tipos = repositorioJustificaciones.ListaTipoJustificaciones().Where(x => !x.IsSalida).ToList();
            this.cboTipoJustificaciones.DataSource = tipos;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {



                DateTime fecha = CalendarDias.SelectionStart;

                if (this.cboTipoJustificaciones.Items.Count == 0) {
                    MessageBox.Show("selecciona el tipo de justificacion");
                    return;
                }

                if (string.IsNullOrEmpty(TxtIdEmpleado.Text))
                {
                    MessageBox.Show("La observacion es importante.");
                    return;
                }


                if (string.IsNullOrEmpty(txtObservaciones.Text))
                {
                    MessageBox.Show("La observacion es importante.");
                    return;
                }


                if (string.IsNullOrEmpty(txtHoras.Text))
                {
                    MessageBox.Show("Ingresa el rango de tiempo de la justificacion");
                    return;
                }

                while (fecha <= CalendarDias.SelectionEnd)
                {
                    GuardaJustficaciones(fecha);
                    fecha = fecha.Date.AddDays(1);
                }

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                CargarJustificaciones();
            }
        }
        private void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            frmBuscador b = new frmBuscador();
            b.tipoBusqueda = "Empleado";
            b.ShowDialog();


            Empleado empleado = repositorioEmpleados.BuscarEmpleadoPorCodigo(int.Parse(b.codigoBusqueda));
            if (empleado != null)
            {
                this.TxtIdEmpleado.Text = empleado.CodigoEmpleado.ToString();
                this.txtNombre.Text = empleado.NombreEmpleado;
            }
            else
            {
                MessageBox.Show("Empleado no encontrado", "Justificaciones");
            }
        }
    }
}
