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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            btnGuardar.Location = new Point(212, 338);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(145, 40);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Entrar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(37, 338);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(139, 40);
            btnCerrar.TabIndex = 20;
            btnCerrar.Text = "Cancelar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 181);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 22;
            label1.Text = "Usuario ";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(37, 208);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 23);
            textBox1.TabIndex = 23;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(37, 282);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(320, 23);
            textBox2.TabIndex = 25;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 253);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 24;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 71);
            label3.Name = "label3";
            label3.Size = new Size(242, 50);
            label3.TabIndex = 26;
            label3.Text = "TH-Manager";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.time_card_48;
            pictureBox1.Location = new Point(182, 121);
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
            label4.Location = new Point(43, 121);
            label4.Name = "label4";
            label4.Size = new Size(133, 17);
            label4.TabIndex = 28;
            label4.Text = "Marcando a Tiempo!";
            // 
            // btnAbrirMarcaciones
            // 
            btnAbrirMarcaciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAbrirMarcaciones.Image = Properties.Resources.icons8_badge_96;
            btnAbrirMarcaciones.Location = new Point(37, 396);
            btnAbrirMarcaciones.Name = "btnAbrirMarcaciones";
            btnAbrirMarcaciones.Size = new Size(320, 40);
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
            lblMensaje.Location = new Point(0, 439);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(391, 51);
            lblMensaje.TabIndex = 30;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(391, 490);
            ControlBox = false;
            Controls.Add(lblMensaje);
            Controls.Add(btnAbrirMarcaciones);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmLogin";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesion";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCerrar;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btnAbrirMarcaciones;
        private Label lblMensaje;
    }
}