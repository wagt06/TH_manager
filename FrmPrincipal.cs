using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace MD
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNuevaMarcacion_Click(object sender, EventArgs e)
        {
            Form m = new FrmMarcacion();
            m.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form empleado = new FrmEmpleado();
            empleado.ShowDialog();
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            Form s = new FrmSucursal();
            s.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            RevisarConfiguracion();

        }

        private void btnMarcaciones_Click(object sender, EventArgs e)
        {
            FrmMarcacionesReporte r = new FrmMarcacionesReporte();
            r.ShowDialog();
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

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmJustificaciones just = new FrmJustificaciones();
            just.ShowDialog();
        }
    }

}
