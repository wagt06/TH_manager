namespace MD
{
    partial class FrmLogin
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
            btnGuardar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            btnAbrirMarcaciones = new Button();
            lblMensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(21, 384);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(365, 47);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Entrar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = Properties.Resources.icons8_close_48;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(360, 4);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(37, 31);
            btnCerrar.TabIndex = 20;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 226);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 22;
            label1.Text = "Usuario ";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(22, 253);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(365, 27);
            txtUsuario.TabIndex = 23;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.Location = new Point(22, 328);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.MaxLength = 50;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(365, 27);
            txtContrasena.TabIndex = 25;
            txtContrasena.KeyPress += txtContrasena_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 301);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 24;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 87);
            label3.Name = "label3";
            label3.Size = new Size(306, 62);
            label3.TabIndex = 26;
            label3.Text = "TH-Manager";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.time_card_48;
            pictureBox1.Location = new Point(65, 153);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(91, 150);
            label4.Name = "label4";
            label4.Size = new Size(205, 23);
            label4.TabIndex = 28;
            label4.Text = "Gestion de colaboradores";
            // 
            // btnAbrirMarcaciones
            // 
            btnAbrirMarcaciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAbrirMarcaciones.Image = Properties.Resources.icons8_badge_96;
            btnAbrirMarcaciones.Location = new Point(21, 439);
            btnAbrirMarcaciones.Margin = new Padding(3, 4, 3, 4);
            btnAbrirMarcaciones.Name = "btnAbrirMarcaciones";
            btnAbrirMarcaciones.Size = new Size(366, 53);
            btnAbrirMarcaciones.TabIndex = 29;
            btnAbrirMarcaciones.Text = " Marcaciones";
            btnAbrirMarcaciones.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAbrirMarcaciones.UseVisualStyleBackColor = true;
            btnAbrirMarcaciones.Click += btnAbrirMarcaciones_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.Dock = DockStyle.Bottom;
            lblMensaje.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensaje.Location = new Point(0, 500);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(409, 49);
            lblMensaje.TabIndex = 30;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(409, 549);
            ControlBox = false;
            Controls.Add(lblMensaje);
            Controls.Add(btnAbrirMarcaciones);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(txtContrasena);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLogin";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesion";
            TopMost = true;
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCerrar;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btnAbrirMarcaciones;
        private Label lblMensaje;
    }
}