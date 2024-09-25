using MD.Cto;
using MD.Entidades;
using MD.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MD
{
    public partial class FrmUsuarios : Form
    {
        RepositorioSeguridad rSeguridad;
        public FrmUsuarios()
        {
            InitializeComponent();
            rSeguridad = new RepositorioSeguridad();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Escribe el nombre del usuario.");
                    return;
                }


                if (string.IsNullOrEmpty(txtContraseña.Text))
                {
                    MessageBox.Show("Escribe la contrasena.");
                    return;
                }

                if (string.IsNullOrEmpty(txtContraseña.Text))
                {
                    MessageBox.Show("Escribe el correo.");
                    return;
                }


                if (!string.Equals(txtContraseña.Text, txtConfirmarContrasena.Text))
                {

                    MessageBox.Show("Las contrasenas no coinciden.");
                    return;
                }


                if (this.cboRol.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecciona el rol del usuario.");
                    return;
                }

                Usuario usuario = new Usuario
                {
                    Nombre = txtNombre.Text,
                    CorreoElectronico = txtCorreo.Text,
                    Contrasena = txtContraseña.Text,
                    RolId = ((SelectCombo)this.cboRol.SelectedItem).Codigo,
                    IsEliminado = !chkActivo.Checked,
                };

                //if (!string.IsNullOrEmpty(TxtId.Text))
                usuario.UsuarioId = !string.IsNullOrEmpty(TxtId.Text) ? int.Parse(TxtId.Text) : 0;

                rSeguridad.UsuarioAddorUpdate(usuario);
                MessageBox.Show("La informacion se guardo correctamente!", "Usuario", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                mostrarDatos();


            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error" + err.Message);
            }
        }

        private void mostrarDatos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = rSeguridad.ListaUsuarios(txtBusqueda.Text);

            this.lwsEmpleados.Items.Clear();
            foreach (var usuario in usuarios)
            {
                ListViewItem item = new ListViewItem(usuario.UsuarioId.ToString());
                item.Tag = usuario;
                item.SubItems.Add(usuario.Nombre);
                item.SubItems.Add(usuario.CorreoElectronico);
                item.SubItems.Add(usuario.Rol.NombreRol);
                lwsEmpleados.Items.Add(item);

            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            this.lwsEmpleados.Columns.Add("Codigo", 100);
            this.lwsEmpleados.Columns.Add("Nombre", 200);
            this.lwsEmpleados.Columns.Add("Correo", 200);
            this.lwsEmpleados.Columns.Add("Rol", 200);
            this.lwsEmpleados.View = View.Details;


            List<Rol> roles = new List<Rol>();
            roles = rSeguridad.Roles();
            List<SelectCombo> r = roles.Select(x => new SelectCombo { Codigo = x.RolId, Descripcion = x.NombreRol }).ToList();

            cboRol.ValueMember = "Codigo";
            cboRol.DisplayMember = "Descripcion";
            this.cboRol.DataSource = r;

            this.cboRol.SelectedIndex = -1;
            mostrarDatos();

        }

        private void lwsEmpleados_DoubleClick(object sender, EventArgs e)
        {
            if (this.lwsEmpleados.Items.Count == 0)
                return;

            if (this.lwsEmpleados.SelectedItems.Count == 0)
                return;

            Usuario usuario = (Usuario)this.lwsEmpleados.SelectedItems[0].Tag;
            llenarUsuario(usuario);
        }

        void llenarUsuario(Usuario usuario)
        {
            this.TxtId.Text = usuario.UsuarioId.ToString();
            txtNombre.Text = usuario.Nombre;
            txtCorreo.Text = usuario.CorreoElectronico;
            txtContraseña.Text = usuario.Contrasena;
            this.cboRol.SelectedValue = usuario.RolId;
            chkActivo.Checked = !usuario.IsEliminado.Value;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            this.cboRol.SelectedValue = -1;
            chkActivo.Checked = true;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}

