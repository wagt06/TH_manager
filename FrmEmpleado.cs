using MD.Cto;
using MD.Entidades;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MD
{
    public partial class FrmEmpleado : Form
    {
        IEnumerable<CtoEmpleados> ctoEmpleados;
        Repositorios.RepositorioEmpleados repositorioEmpleado = new Repositorios.RepositorioEmpleados();
        public FrmEmpleado()
        {
            InitializeComponent();


            this.lwsEmpleados.Columns.Add("Codigo", 100);
            this.lwsEmpleados.Columns.Add("Nombre", 250);
            this.lwsEmpleados.Columns.Add("Cedula", 150);
            this.lwsEmpleados.Columns.Add("Sucursal", 150);
            this.lwsEmpleados.Columns.Add("Activo", 100);

            CargarSucursales();
            CargarEmpleados();
            CargarHorarios();

            gbUsuario.Enabled = false;
            TxtId.Enabled = true;
        }

        private void CargarSucursales()
        {
            List<Cto.SelectCombo> sucursales;
            using (MdDbContext db = new MdDbContext())
            {
                sucursales = db.Sucursales.Where(x => x.IsActivo).Select(x => new Cto.SelectCombo { Codigo = x.CodigoSucursal, Descripcion = x.Nombre }).ToList();
            }
            Tools.LlenarControles.LlenarCombo(this.cboSucursal, sucursales);
        }

        private void CargarHorarios()
        {
            List<SelectCombo> horarios;
            using (MdDbContext db = new MdDbContext())
            {
                horarios = db.Horarios.Where(x => x.IsActivo).Select(x => new Cto.SelectCombo { Codigo = x.CodigoHorario, Descripcion = x.Descripcion }).ToList();
            }

            Tools.LlenarControles.LlenarCombo(this.cboHorarios, horarios);
        }

        private void CargarEmpleados()
        {
            try
            {
                this.lwsEmpleados.Items.Clear();
                ctoEmpleados = repositorioEmpleado.ListCtoEmpleados();

                foreach (CtoEmpleados e in ctoEmpleados)
                {
                    ListViewItem lista = new ListViewItem(e.Codigo.ToString());
                    lista.SubItems.Add(e.Nombre);
                    lista.SubItems.Add(e.Cedula);
                    lista.SubItems.Add(e.Sucursal);
                    lista.SubItems.Add(e.Activo.ToString());
                    this.lwsEmpleados.Items.Add(lista);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.TxtId.Enabled = true;
        }


        private void Limpiar()
        {

            this.TxtId.Text = "";
            this.txtNombre.Text = "";
            this.txtCedula.Text = "";
            this.chkActivo.Checked = true;
            this.cboHorarios.SelectedValue = -1;
            this.cboSucursal.SelectedValue = -1;
            this.txtUsuario.Text = "";
            this.txtContraseña.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lwsEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lwsEmpleados.Items.Count > 0)
                {
                    if (this.lwsEmpleados.SelectedItems[0].Text != "")
                    {

                        int codigo = int.Parse(this.lwsEmpleados.SelectedItems[0].Text);
                        CtoEmpleados empleado = repositorioEmpleado.CtoEmpleadosPorCodigo(codigo);
                        this.TxtId.Text = empleado.Codigo.ToString();
                        this.txtNombre.Text = empleado.Nombre;
                        txtCedula.Text = empleado.Cedula;
                        cboSucursal.SelectedValue = empleado.CodigoSucursal;
                        cboHorarios.SelectedValue = empleado.CodigoHorario;
                        this.txtUsuario.Text = empleado.Usuario;
                        this.txtContraseña.Text = empleado.Contraseña;
                        this.chkUsuario.Checked = empleado.IsUsuario;
                        this.chkActivo.Checked = empleado.Activo;
                        this.TxtId.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtId.Text.Length == 0 || txtNombre.Text.Length == 0 || txtCedula.Text.Length == 0 || (int)this.cboSucursal.SelectedValue < 0 || (int)this.cboHorarios.SelectedValue < 0)
                {
                    MessageBox.Show("todos los campos son requeridos");
                    return;
                }

                Empleado empleado = new Empleado
                {
                    CodigoEmpleado = this.TxtId.Text.Length > 0 ? int.Parse(this.TxtId.Text) : 0,
                    NombreEmpleado = this.txtNombre.Text,
                    Cedula = txtCedula.Text,
                    IsActivo = chkActivo.Checked,

                    CodigoSucursal = ((Cto.SelectCombo)this.cboSucursal.SelectedItem).Codigo,
                    CodigoHorario = ((Cto.SelectCombo)this.cboHorarios.SelectedItem).Codigo,

                    Usuario = this.txtUsuario.Text ?? "",
                    Contraseña = this.txtContraseña.Text ?? "",
                    IsUsuario = this.chkUsuario.Checked
                };

                repositorioEmpleado.GuardarEmpleado(empleado);


                CargarEmpleados();
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            this.gbUsuario.Enabled = chkUsuario.Checked;
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
