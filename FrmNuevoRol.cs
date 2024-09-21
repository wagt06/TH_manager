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

namespace MD
{
    public partial class FrmNuevoRol : Form
    {
        RepositorioSeguridad rSeguridad = new RepositorioSeguridad();
        public FrmNuevoRol()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
                return;

            if (string.IsNullOrEmpty(txtId.Text))
                rSeguridad.Add(new Entidades.Rol { NombreRol = txtNombre.Text, IsActivo = this.chkActivo.Checked });
            else
            {
                rSeguridad.Update(new Entidades.Rol { RolId = int.Parse(txtId.Text), NombreRol = txtNombre.Text, IsActivo = this.chkActivo.Checked });
            }

            MessageBox.Show("La informacion se guardo correctamente.");
            this.Close();

        }
    }
}
