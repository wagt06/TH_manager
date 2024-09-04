namespace MD
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevaMarcacion = new Button();
            btnSucursales = new Button();
            btnEmpleado = new Button();
            btnMarcaciones = new Button();
            lblError = new Label();
            cmdJustificaciones = new Button();
            SuspendLayout();
            // 
            // btnNuevaMarcacion
            // 
            btnNuevaMarcacion.Image = Properties.Resources.icons8_security_pass_96;
            btnNuevaMarcacion.ImageAlign = ContentAlignment.TopCenter;
            btnNuevaMarcacion.Location = new Point(173, 324);
            btnNuevaMarcacion.Margin = new Padding(3, 4, 3, 4);
            btnNuevaMarcacion.Name = "btnNuevaMarcacion";
            btnNuevaMarcacion.Size = new Size(184, 157);
            btnNuevaMarcacion.TabIndex = 0;
            btnNuevaMarcacion.Text = "Marcar";
            btnNuevaMarcacion.TextAlign = ContentAlignment.BottomCenter;
            btnNuevaMarcacion.UseVisualStyleBackColor = true;
            btnNuevaMarcacion.Click += btnNuevaMarcacion_Click;
            // 
            // btnSucursales
            // 
            btnSucursales.Image = Properties.Resources.icons8_permanent_job_96;
            btnSucursales.ImageAlign = ContentAlignment.TopCenter;
            btnSucursales.Location = new Point(173, 131);
            btnSucursales.Margin = new Padding(3, 4, 3, 4);
            btnSucursales.Name = "btnSucursales";
            btnSucursales.Size = new Size(184, 157);
            btnSucursales.TabIndex = 1;
            btnSucursales.Text = "Sucursales";
            btnSucursales.TextAlign = ContentAlignment.BottomCenter;
            btnSucursales.UseVisualStyleBackColor = true;
            btnSucursales.Click += btnSucursales_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Image = Properties.Resources.icons8_manager_96;
            btnEmpleado.ImageAlign = ContentAlignment.TopCenter;
            btnEmpleado.Location = new Point(381, 131);
            btnEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(184, 157);
            btnEmpleado.TabIndex = 2;
            btnEmpleado.Text = "Empleados";
            btnEmpleado.TextAlign = ContentAlignment.BottomCenter;
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += button2_Click;
            // 
            // btnMarcaciones
            // 
            btnMarcaciones.Image = Properties.Resources.icons8_checked_identification_documents_96;
            btnMarcaciones.ImageAlign = ContentAlignment.TopCenter;
            btnMarcaciones.Location = new Point(591, 131);
            btnMarcaciones.Margin = new Padding(3, 4, 3, 4);
            btnMarcaciones.Name = "btnMarcaciones";
            btnMarcaciones.Size = new Size(184, 157);
            btnMarcaciones.TabIndex = 3;
            btnMarcaciones.Text = "Marcaciones";
            btnMarcaciones.TextAlign = ContentAlignment.BottomCenter;
            btnMarcaciones.UseVisualStyleBackColor = true;
            btnMarcaciones.Click += btnMarcaciones_Click;
            // 
            // lblError
            // 
            lblError.BackColor = Color.FromArgb(255, 128, 128);
            lblError.Dock = DockStyle.Bottom;
            lblError.Location = new Point(0, 580);
            lblError.Name = "lblError";
            lblError.Size = new Size(914, 47);
            lblError.TabIndex = 4;
            lblError.TextAlign = ContentAlignment.TopCenter;
            lblError.Visible = false;
            // 
            // cmdJustificaciones
            // 
            cmdJustificaciones.Image = Properties.Resources.icons8_discord_staff_badge_96;
            cmdJustificaciones.ImageAlign = ContentAlignment.TopCenter;
            cmdJustificaciones.Location = new Point(381, 324);
            cmdJustificaciones.Margin = new Padding(3, 4, 3, 4);
            cmdJustificaciones.Name = "cmdJustificaciones";
            cmdJustificaciones.Size = new Size(184, 157);
            cmdJustificaciones.TabIndex = 5;
            cmdJustificaciones.Text = "Justificaciones";
            cmdJustificaciones.TextAlign = ContentAlignment.BottomCenter;
            cmdJustificaciones.UseVisualStyleBackColor = true;
            cmdJustificaciones.Click += button1_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 627);
            Controls.Add(cmdJustificaciones);
            Controls.Add(lblError);
            Controls.Add(btnMarcaciones);
            Controls.Add(btnEmpleado);
            Controls.Add(btnSucursales);
            Controls.Add(btnNuevaMarcacion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            Text = "Principal Marcador";
            FormClosing += FrmPrincipal_FormClosing;
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevaMarcacion;
        private Button btnSucursales;
        private Button btnEmpleado;
        private Button btnMarcaciones;
        private Label lblError;
        private Button cmdJustificaciones;
    }
}