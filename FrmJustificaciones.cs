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
        bool tienePermisoParaAprobar = false;
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
            this.lblTipoJustificacion.Visible = false;
            gbEstado.Enabled = false;

            dtpFechaInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
            dtpFechaFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 1, 0, 0, 0).AddDays(-1);

            dtpInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            dtpFin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0);

            tienePermisoParaAprobar = Configuraciones.Usuario.TienePermisoOpcion(new MenusOpciones { MenuId = 2, MenuOpcionesId = 7 });

            this.gbEstado.Enabled = false;
            this.btnAprobarMasivo.Enabled = false;
            this.btnRechazarMasivo.Enabled = false;
        }
        private void CargarJustificaciones()
        {
            this.lwsJustificaciones.Items.Clear();

            FiltroBusqueda filtro = new FiltroBusqueda
            {
                FechaInicial = dtpFechaInicial.Value,
                FechaFinal = dtpFechaFinal.Value,
                IsPendiente = ChkPendientes.Checked
            };

            JustificacionesLista = repositorioJustificaciones.CtoJustificacionLista(filtro);

            if (!string.IsNullOrEmpty(TxtIdEmpleado.Text))
            {
                JustificacionesLista = JustificacionesLista.Where(x => x.CodigoEmpleado == int.Parse(TxtIdEmpleado.Text)).OrderBy(x => x.Fecha);
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
        }
        private void CalcularHorasJustificadas()
        {
            decimal horas = (dtpFin.Value - dtpInicio.Value).Hours;
            decimal minutos = (dtpFin.Value - dtpInicio.Value).Minutes;
            this.txtHoras.Text = (minutos > 0 ? horas + (minutos / 60) : horas).ToString();
        }
        private void dtpInicio_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularHorasJustificadas();
        }

        private void dtpFin_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularHorasJustificadas();
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            CalcularHorasJustificadas();
        }

        private void dtpInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalcularHorasJustificadas();
        }

        private void dtpFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalcularHorasJustificadas();
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            CalcularHorasJustificadas();
        }




        private bool GuardarJustficaciones(DateTime fecha)
        {
            try
            {
                TipoJustificacion tipo = (TipoJustificacion)cboTipoJustificaciones.SelectedItem;
                Justificacion justificacion;
                Justificacion nuevaJustificacion = new Justificacion
                {
                    CodigoJustificacion = int.Parse(string.IsNullOrEmpty(this.txtCodigoJustificacion.Text) ? "0" : this.txtCodigoJustificacion.Text),
                    CodigoEmpleado = int.Parse(TxtIdEmpleado.Text),
                    CodigoTipoJustificacion = tipo.CodigoTipoJustificacion,
                    Fecha = fecha,
                    HoraInicial = new DateTime(fecha.Year, fecha.Month, fecha.Day, dtpInicio.Value.Hour, dtpInicio.Value.Minute, 0),
                    HoraFinal = new DateTime(fecha.Year, fecha.Month, fecha.Day, dtpFin.Value.Hour, dtpFin.Value.Minute, 0),
                    Horas = decimal.Parse(txtHoras.Text),
                    Observacion = txtObservaciones.Text,
                    CodigoUsuarioCreacion = 1,
                    FechaCreacion = DateTime.Now,
                    IsEliminado = false,
                    IsFeriado = false,
                    CodigoEstado = 1,
                    IsPermiso = tipo.IsSalida
                };

                Justificacion existeJustificacion = repositorioJustificaciones.JustificacionPorFechaTipo(nuevaJustificacion);


                if (existeJustificacion != null)
                {
                    MessageBox.Show($"ya existe justificacion de salida para {existeJustificacion.Fecha.ToString("yyy/mm/dd")} de {existeJustificacion.HoraInicial.ToString("hh:mm:ss")} a {existeJustificacion.HoraFinal.ToString("hh:mm:ss")}");
                    return false;
                }
                else
                {
                    justificacion = repositorioJustificaciones.GuardarJustificacion(nuevaJustificacion);
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void Limpiar()
        {
            txtCodigoJustificacion.Text = "";
            TxtIdEmpleado.Text = "";
            txtNombre.Text = "";
            txtObservaciones.Text = "";
            txtHoras.Text = "";
            cboTipoJustificaciones.SelectedIndex = -1;
            gbEstado.Enabled = false;
            lblTipoJustificacion.Visible = false;
            this.CalendarDias.TodayDate = DateTime.Now;
            this.CalendarDias.SelectionEnd = DateTime.Now;
            this.CalendarDias.SelectionStart = DateTime.Now;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            CargarJustificaciones();
        }
        private void LwsJustificaciones_DoubleClick(object sender, EventArgs e)
        {
            if (this.lwsJustificaciones.Items.Count > 0)
            {

                if (this.lwsJustificaciones.SelectedItems.Count > 0)
                {
                    MostrarJustificacion(int.Parse(this.lwsJustificaciones.SelectedItems[0].Text));
                }
            }
        }
        private void MostrarJustificacion(int codigoJustificacion)
        {

            CtoJustificacion justificacion = repositorioJustificaciones.CtoJustificacionById(codigoJustificacion);

            if (justificacion != null)
            {
                this.rdPermiso.Checked = justificacion.IsPermiso;
                this.txtCodigoJustificacion.Text = justificacion.CodigoJustificacion.ToString();
                this.TxtIdEmpleado.Text = justificacion.CodigoEmpleado.ToString();
                this.txtNombre.Text = justificacion.NombreEmpleado;
                this.txtObservaciones.Text = justificacion.Observaciones;
                this.txtHoras.Text = justificacion.Horas.ToString();
                cboTipoJustificaciones.SelectedValue = justificacion.CodigoTipoJustificacion;
                CalendarDias.SetDate(justificacion.Fecha);
                dtpInicio.Value = justificacion.HoraInicio;
                dtpFin.Value = justificacion.HoraFin;

                this.gbEstado.Enabled = justificacion.CodigoEstado == 1 && this.tienePermisoParaAprobar;

                if (!this.gbEstado.Enabled)
                {
                    cmdRechazar.Enabled = false;
                    cmdAprobar.Enabled = false;
                    cmdAprobar.Visible = justificacion.CodigoEstado == 2;
                    cmdRechazar.Visible = justificacion.CodigoEstado == 3;
                    btnGuardarJust.Enabled = false;
                    if (justificacion.CodigoEstado == 1) {
                        cmdAprobar.Visible = true;
                        cmdRechazar.Visible = true;
                    }
                }
                else
                {
                    cmdAprobar.Enabled = true;
                    cmdRechazar.Enabled = true;
                    cmdAprobar.Visible = true;
                    cmdRechazar.Visible = true;
                  
                }
                btnGuardarJust.Enabled = justificacion.CodigoEstado == 1;
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnGuardarJust.Enabled = true;

        }
        private void RdPermiso_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdPermiso.Checked)
            {
                IEnumerable<TipoJustificacion> tipos = repositorioJustificaciones.ListaTipoJustificaciones().Where(x => x.IsSalida).ToList();
                this.cboTipoJustificaciones.DataSource = tipos;
                this.lblTipoJustificacion.BackColor = Color.LightCoral;
                this.lblTipoJustificacion.Text = "Justificacion de Ausencia";

            }
            else
            {
                IEnumerable<TipoJustificacion> tipos = repositorioJustificaciones.ListaTipoJustificaciones().Where(x => !x.IsSalida).ToList();
                this.cboTipoJustificaciones.DataSource = tipos;
                this.lblTipoJustificacion.BackColor = Color.OliveDrab;
                this.lblTipoJustificacion.Text = "Justificacion de horas extras";
            }
            this.lblTipoJustificacion.Visible = true;
        }
        private void RdHoraExtra_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = CalendarDias.SelectionStart;

                if (this.cboTipoJustificaciones.Items.Count == 0)
                {
                    MessageBox.Show("selecciona el tipo de justificacion");
                    return;
                }


                if (this.cboTipoJustificaciones.SelectedIndex < 0)
                {
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


                int dias = 0;
                while (fecha <= CalendarDias.SelectionEnd)
                {
                    if (GuardarJustficaciones(fecha)) {
                        dias += 1;
                    }
                    fecha = fecha.Date.AddDays(1);
                }

                
                if (dias == 1)
                    MessageBox.Show($"Las Justificaciones se guardaron correctamente");
                if (dias > 1)
                    MessageBox.Show($"Las Justificaciones se guardaron correctamente");
                if(dias>=1)
                    Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Limpiar();
            CargarJustificaciones();
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

        private void cmdAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoJustificacion.Text))
                    return;

                Justificacion justificacion = repositorioJustificaciones.UpdateEstado(int.Parse(txtCodigoJustificacion.Text), 2);
                MostrarJustificacion(int.Parse(txtCodigoJustificacion.Text));
                MessageBox.Show("La informacion se proceso correctamente");
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
        private void cmdRechazar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoJustificacion.Text))
                    return;
                Justificacion justificacion = repositorioJustificaciones.UpdateEstado(int.Parse(txtCodigoJustificacion.Text), 3);
                MostrarJustificacion(int.Parse(txtCodigoJustificacion.Text));
                MessageBox.Show("La informacion se proceso correctamente");
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            frmBuscador b = new frmBuscador();
            b.tipoBusqueda = "Empleado";
            b.ShowDialog();


            Empleado empleado = repositorioEmpleados.BuscarEmpleadoPorCodigo(int.Parse(b.codigoBusqueda));
            if (empleado != null)
            {
                this.txtCodigoEmpleadoFiltro.Text = empleado.CodigoEmpleado.ToString();
                this.txtEmpleadoFiltro.Text = empleado.NombreEmpleado;
            }
            else
            {
                MessageBox.Show("Empleado no encontrado", "Justificaciones");
            }
        }

        private void lwsJustificaciones_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            this.btnAprobarMasivo.Enabled = this.lwsJustificaciones.CheckedItems.Count > 0 && tienePermisoParaAprobar;
            this.btnRechazarMasivo.Enabled = this.lwsJustificaciones.CheckedItems.Count > 0 && tienePermisoParaAprobar;

            if (e.Item.Checked && e.Item.SubItems[3].Text != "Pendiente")
            {
                e.Item.Checked = !e.Item.Checked;
            }

        }

        private void btnAprobarMasivo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Segura que dese aprobar masivamente todas las justificaciones seleccionadas", "Justificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            foreach (ListViewItem item in this.lwsJustificaciones.CheckedItems)
            {
                Justificacion justificacion = repositorioJustificaciones.UpdateEstado(int.Parse(item.Text), 2);
                item.SubItems[3].Text = "Aprobado";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Segura que dese rechazar masivamente todas las justificaciones seleccionadas", "Justificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            foreach (ListViewItem item in this.lwsJustificaciones.CheckedItems)
            {
                Justificacion justificacion = repositorioJustificaciones.UpdateEstado(int.Parse(item.Text), 3);
                item.SubItems[3].Text = "Rechazado";
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Tools.Tool.CopyListBox(this.lwsJustificaciones);
        }
    }
}
