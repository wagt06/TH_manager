using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD
{
    public partial class FormPrincipalMdi : Form
    {
        public FormPrincipalMdi()
        {
            InitializeComponent();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void btnNuevaMarcacion_Click(object sender, EventArgs e)
        {
            Form m = new FrmMarcacion();
            m.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Form empleado = new FrmEmpleado { MdiParent = this };
            empleado.Show();
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            Form s = new FrmSucursal { MdiParent = this };
            s.Show();
        }


        private void btnMarcaciones_Click(object sender, EventArgs e)
        {
            FrmMarcacionesReporte r = new FrmMarcacionesReporte { MdiParent = this };
            r.Show();
        }

        private void RevisarConfiguracion()
        {

            Thread.CurrentThread.CurrentCulture.ClearCachedData();
            var thread = new Thread(
                s => ((State)s).Result = Thread.CurrentThread.CurrentCulture);
            var state = new State();
            thread.Start(state);
            thread.Join();
            var culture = state.Result;

            lblError.Visible = false;
            if (culture.Name != "es-NI")
            {
                lblError.Visible = true;
                lblError.Text = "La configuración regional tiene que ser es-NI";
            }

        }


        private void cmdJustificaciones_Click(object sender, EventArgs e)
        {
            FrmJustificaciones just = new FrmJustificaciones { MdiParent = this };
            just.Show();
        }

        private void FormPrincipalMdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void FormPrincipalMdi_Load(object sender, EventArgs e)
        {
            RevisarConfiguracion();
        }
    }

    public class State
    {
        public CultureInfo Result { get; set; }
    }
}

