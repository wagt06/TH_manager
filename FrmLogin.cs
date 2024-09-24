using MD.Entidades;
using MD.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD
{
    public partial class FrmLogin : Form
    {

        RepositorioSeguridad rSeguridad;
        public FrmLogin()
        {
            InitializeComponent();
            rSeguridad = new RepositorioSeguridad();
        }


        async private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!(this.txtUsuario.Text.Length > 0 && this.txtContrasena.Text.Length > 0))
                return;

            bool isLogin = await Login();
            if (isLogin)
            {
                this.Hide();
                new FormPrincipalMdi().Show();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        async private Task<bool> Login()
        {

            try
            {
                bool resultado = false;
                string mensaje = "";
                Usuario empleado;
                using (DbContext db = new DbContext())
                {
                    //empleado = db.Empleados
                    //    .Where(x => x.IsUsuario && x.Usuario == this.textBox1.Text && x.Contraseña == this.textBox2.Text)
                    //    .FirstOrDefault();

                    empleado = db.Usuarios
                        .Include(x => x.Rol)
                        .Where(x => x.Nombre == this.txtUsuario.Text && x.Contrasena == this.txtContrasena.Text)
                        .FirstOrDefault();

                }

                mensaje = empleado != null ? $"Bienvenido {empleado.Nombre}" : "Usuario o la contraseña invalidos";


                this.lblMensaje.BackColor = empleado != null ? Color.Green : Color.Red;
                this.lblMensaje.ForeColor = Color.White;
                this.lblMensaje.Visible = true;
                this.lblMensaje.Text = mensaje;

                resultado = empleado != null;
                if (empleado != null)
                {

                    Usuario usuarioLogiado = rSeguridad.UsuarioById(empleado.UsuarioId);

                    if (usuarioLogiado == null)
                        throw new Exception("No se encontraron permisos de seguridad para este usuario");

                    Configuraciones.Usuario = usuarioLogiado;
                }

                await Task.Delay(2000);
                this.lblMensaje.Visible = false;
                return resultado;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.Message);
                return false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirMarcaciones_Click(object sender, EventArgs e)
        {
            FrmMarcacion m = new FrmMarcacion();
            m.isAbiertoDesdeLogin = true;
            m.Show();
            this.Hide();

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGuardar_Click(null, null);
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGuardar_Click(null, null);
            }
        }

    }
}
