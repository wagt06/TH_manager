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
        Ribbon r;
        public FormPrincipalMdi()
        {
            InitializeComponent();
            r = new Ribbon();
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
            //AbrirForm(new FrmMarcacion());
            FrmMarcacion m = new FrmMarcacion();
            m.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            if (!TienPermisoParaElMenu(1))
            {
                return;
            }

            AbrirForm(new FrmEmpleado());
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            if (!TienPermisoParaElMenu(5))
            {
                return;
            }

            AbrirForm(new FrmSucursal());
        }


        private void btnMarcaciones_Click(object sender, EventArgs e)
        {
            if (!TienPermisoParaElMenu(3))
            {
                return;
            }

            AbrirForm(new FrmMarcacionesReporte());
        }

        private void AbrirForm(Form form)
        {


            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();

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
            if (!TienPermisoParaElMenu(2))
            {
                return;
            }


            AbrirForm(new FrmJustificaciones());

        }

        private void FormPrincipalMdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void FormPrincipalMdi_Load(object sender, EventArgs e)
        {
            RevisarConfiguracion();


            r.Dock = DockStyle.Top;
            r.OrbImage = Properties.Resources.time_card_48;
            r.Theme.Style = RibbonOrbStyle.Office_2013;
            r.Height = 150;

            /*Empleados*/
            RibbonTab tbEmpleados = new RibbonTab { Text = "Empleados" };
            RibbonPanel panel = new RibbonPanel { Text = "Mantenimiento" };

            RibbonButton btnFichaEmpleado = new RibbonButton { Text = "Ficha Empleado", Image = Properties.Resources.icons8_manager_96 };
            RibbonButton btnMarcacion = new RibbonButton { Text = "Marcaciones", Image = Properties.Resources.icons8_checked_identification_documents_96 };
            RibbonButton btnJustificaciones = new RibbonButton { Text = "Justificaciones", Image = Properties.Resources.time_card_48 };

            btnFichaEmpleado.Click += btnEmpleado_Click;
            btnMarcacion.Click += btnNuevaMarcacion_Click;
            btnJustificaciones.Click += cmdJustificaciones_Click;

            panel.Items.Add(btnFichaEmpleado);
            panel.Items.Add(btnMarcacion);
            panel.Items.Add(btnJustificaciones);

            tbEmpleados.Panels.Add(panel);

            /*Empresa*/
            RibbonTab tbEmpresa = new RibbonTab { Text = "Empresa" };
            RibbonPanel panelEmpresa = new RibbonPanel { Text = "Mantenimiento" };

            RibbonButton btnFichaSucursales = new RibbonButton { Text = "Ficha Sucursales", Image = Properties.Resources.icons8_permanent_job_96 };
            btnFichaSucursales.Click += btnSucursales_Click;

            panelEmpresa.Items.Add(btnFichaSucursales);
            tbEmpresa.Panels.Add(panelEmpresa);

            /*Reportes*/
            RibbonTab tbSeguridad = new RibbonTab { Text = "Seguridad" };
            RibbonPanel panelSeguridad = new RibbonPanel { Text = "Mantenimiento" };

            RibbonButton btnUsuarios = new RibbonButton { Text = "Usuarios", Image = Properties.Resources.icons8_manager_96 };
            RibbonButton btnPermisos = new RibbonButton { Text = "Roles", Image = Properties.Resources.icons8_permanent_job_96 };
            
            btnPermisos.Click += cmdSeguridad_Click;
            btnUsuarios.Click += BtnUsuarios_Click;


            panelSeguridad.Items.Add(btnUsuarios);
            panelSeguridad.Items.Add(btnPermisos);
            tbSeguridad.Panels.Add(panelSeguridad);


            /*Seguridad*/
            RibbonTab tbReportes = new RibbonTab { Text = "Reportes" };
            RibbonPanel panelReportes = new RibbonPanel { Text = "Mantenimiento" };

            RibbonButton btnMarcaciones = new RibbonButton { Text = "Marcaciones", Image = Properties.Resources.icons8_checked_identification_documents_96 };
            btnMarcaciones.Click += btnMarcaciones_Click;

            panelReportes.Items.Add(btnMarcaciones);
            tbReportes.Panels.Add(panelReportes);


            r.Tabs.Add(tbEmpleados);
            r.Tabs.Add(tbEmpresa);
            r.Tabs.Add(tbSeguridad);
            r.Tabs.Add(tbReportes);


            this.Controls.Add(r);


        }

        private void BtnUsuarios_Click(object? sender, EventArgs e)
        {
            if (!TienPermisoParaElMenu(2))
            {
                return;
            }


            AbrirForm(new FrmUsuarios());

        }

        //private void LoadformEmpleado()
        //{
        //   return this.btnEmpleado_Click(null, null);
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdSeguridad_Click(object sender, EventArgs e)
        {

            if (!TienPermisoParaElMenu(4))
            {
                return;
            }


            AbrirForm(new FrmSeguridad());
            //AddTab(just);
        }

        private bool TienPermisoParaElMenu(int menuId)
        {

            if (!Configuraciones.Usuario.TienePermisoMenu(new Entidades.Menu { MenuId = menuId }))
            {
                MessageBox.Show("No tiene Permiso para este modulo", "Seguridad del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void AddTab(Form childForm)
        {
            // Crear una nueva pestaña
            TabPage tabPage = new TabPage(childForm.Text);
            tabPage.Controls.Add(childForm);
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;

            //Button btnCerrar = new Button();
            //btnCerrar.Text = "Cerrar Pestaña";
            //btnCerrar.Dock = DockStyle.Top;
            //btnCerrar.Click += new EventHandler((sender, e) => CerrarPestaña(tabPage));
            //tabPage.
            //tabPage.Controls.Add(btnCerrar);


            childForm.Show();

            // Agregar la pestaña al TabControl
            tabControl1.TabPages.Add(tabPage);
        }


        private void CerrarPestaña(TabPage pestaña)
        {
            tabControl1.TabPages.Remove(pestaña);
        }


    }

    public class State
    {
        public CultureInfo Result { get; set; }
    }
}

