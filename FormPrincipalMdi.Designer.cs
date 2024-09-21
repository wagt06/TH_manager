namespace MD
{
    partial class FormPrincipalMdi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            cmdJustificaciones = new Button();
            btnMarcaciones = new Button();
            btnEmpleado = new Button();
            btnSucursales = new Button();
            btnNuevaMarcacion = new Button();
            lblError = new Label();
            panel1 = new Panel();
            cmdSeguridad = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            statusStrip.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 549);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 17, 0);
            statusStrip.Size = new Size(913, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(42, 17);
            toolStripStatusLabel.Text = "Estado";
            // 
            // cmdJustificaciones
            // 
            cmdJustificaciones.Image = Properties.Resources.icons8_discord_staff_badge_96;
            cmdJustificaciones.ImageAlign = ContentAlignment.TopCenter;
            cmdJustificaciones.Location = new Point(12, 122);
            cmdJustificaciones.Name = "cmdJustificaciones";
            cmdJustificaciones.Size = new Size(110, 49);
            cmdJustificaciones.TabIndex = 10;
            cmdJustificaciones.Text = "Justificaciones";
            cmdJustificaciones.TextAlign = ContentAlignment.BottomCenter;
            cmdJustificaciones.UseVisualStyleBackColor = true;
            cmdJustificaciones.Click += cmdJustificaciones_Click;
            // 
            // btnMarcaciones
            // 
            btnMarcaciones.Image = Properties.Resources.icons8_checked_identification_documents_96;
            btnMarcaciones.ImageAlign = ContentAlignment.TopCenter;
            btnMarcaciones.Location = new Point(12, 230);
            btnMarcaciones.Name = "btnMarcaciones";
            btnMarcaciones.Size = new Size(110, 48);
            btnMarcaciones.TabIndex = 9;
            btnMarcaciones.Text = "Marcaciones";
            btnMarcaciones.TextAlign = ContentAlignment.BottomCenter;
            btnMarcaciones.UseVisualStyleBackColor = true;
            btnMarcaciones.Click += btnMarcaciones_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Image = Properties.Resources.icons8_manager_96;
            btnEmpleado.ImageAlign = ContentAlignment.TopCenter;
            btnEmpleado.Location = new Point(13, 69);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(109, 47);
            btnEmpleado.TabIndex = 8;
            btnEmpleado.Text = "Empleados";
            btnEmpleado.TextAlign = ContentAlignment.BottomCenter;
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnSucursales
            // 
            btnSucursales.Image = Properties.Resources.icons8_permanent_job_96;
            btnSucursales.ImageAlign = ContentAlignment.TopCenter;
            btnSucursales.Location = new Point(13, 16);
            btnSucursales.Name = "btnSucursales";
            btnSucursales.Size = new Size(110, 47);
            btnSucursales.TabIndex = 7;
            btnSucursales.Text = "Sucursales";
            btnSucursales.TextAlign = ContentAlignment.BottomCenter;
            btnSucursales.UseVisualStyleBackColor = true;
            btnSucursales.Click += btnSucursales_Click;
            // 
            // btnNuevaMarcacion
            // 
            btnNuevaMarcacion.Image = Properties.Resources.icons8_security_pass_96;
            btnNuevaMarcacion.ImageAlign = ContentAlignment.TopCenter;
            btnNuevaMarcacion.Location = new Point(13, 177);
            btnNuevaMarcacion.Name = "btnNuevaMarcacion";
            btnNuevaMarcacion.Size = new Size(109, 47);
            btnNuevaMarcacion.TabIndex = 6;
            btnNuevaMarcacion.Text = "Marcar";
            btnNuevaMarcacion.TextAlign = ContentAlignment.BottomCenter;
            btnNuevaMarcacion.UseVisualStyleBackColor = true;
            btnNuevaMarcacion.Click += btnNuevaMarcacion_Click;
            // 
            // lblError
            // 
            lblError.BackColor = Color.FromArgb(255, 128, 128);
            lblError.Dock = DockStyle.Bottom;
            lblError.Location = new Point(0, 514);
            lblError.Name = "lblError";
            lblError.Size = new Size(913, 35);
            lblError.TabIndex = 12;
            lblError.TextAlign = ContentAlignment.TopCenter;
            lblError.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmdSeguridad);
            panel1.Controls.Add(btnSucursales);
            panel1.Controls.Add(btnNuevaMarcacion);
            panel1.Controls.Add(cmdJustificaciones);
            panel1.Controls.Add(btnEmpleado);
            panel1.Controls.Add(btnMarcaciones);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(131, 514);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // cmdSeguridad
            // 
            cmdSeguridad.Image = Properties.Resources.icons8_checked_identification_documents_96;
            cmdSeguridad.ImageAlign = ContentAlignment.TopCenter;
            cmdSeguridad.Location = new Point(10, 284);
            cmdSeguridad.Name = "cmdSeguridad";
            cmdSeguridad.Size = new Size(110, 48);
            cmdSeguridad.TabIndex = 11;
            cmdSeguridad.Text = "Seguridad";
            cmdSeguridad.TextAlign = ContentAlignment.BottomCenter;
            cmdSeguridad.UseVisualStyleBackColor = true;
            cmdSeguridad.Click += cmdSeguridad_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(854, 379);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(37, 29);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(29, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // FormPrincipalMdi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 571);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(lblError);
            Controls.Add(statusStrip);
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "FormPrincipalMdi";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipalMdi_FormClosing;
            Load += FormPrincipalMdi_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolTip toolTip;
        private Button cmdJustificaciones;
        private Button btnMarcaciones;
        private Button btnEmpleado;
        private Button btnSucursales;
        private Button btnNuevaMarcacion;
        private Label lblError;
        private Panel panel1;
        private Button cmdSeguridad;
        private TabControl tabControl1;
        private TabPage tabPage1;
    }
}



