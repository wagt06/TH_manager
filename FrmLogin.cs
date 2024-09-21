using MD.Entidades;
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
        public FrmLogin()
        {
            InitializeComponent();
        }


        async private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!(this.textBox1.Text.Length > 0 && this.textBox2.Text.Length > 0))
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
                Empleado empleado;
                using (DbContext db = new DbContext())
                {
                    empleado = db.Empleados
                        .Where(x => x.IsUsuario && x.Usuario == this.textBox1.Text && x.Contraseña == this.textBox2.Text)
                        .FirstOrDefault();
                }

                mensaje = empleado != null ? $"Bienvenido {empleado.NombreEmpleado}" : "Usuario o la contraseña invalidos";
                resultado = empleado != null;


                this.lblMensaje.BackColor = empleado != null ? Color.Green : Color.Red;
                this.lblMensaje.ForeColor = Color.White;
                this.lblMensaje.Visible = true;
                this.lblMensaje.Text = mensaje;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGuardar_Click(null, null);
            }
        }
    }
}
