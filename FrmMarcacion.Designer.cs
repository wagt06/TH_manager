namespace MD
{
    partial class FrmMarcacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarcacion));
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            btnMarcar = new Button();
            txtId = new TextBox();
            label1 = new Label();
            lblFecha = new Label();
            lblHora = new Label();
            gbMarcacion = new GroupBox();
            label2 = new Label();
            PicEmpleado = new PictureBox();
            lblEmpleado = new Label();
            lblSucursalNombre = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            gbMarcacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicEmpleado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Right;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Controls.Add(lblHora);
            groupBox1.Controls.Add(gbMarcacion);
            groupBox1.Location = new Point(481, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 532);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(btnMarcar);
            panel1.Controls.Add(txtId);
            panel1.Location = new Point(145, 212);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 52);
            panel1.TabIndex = 10;
            // 
            // btnMarcar
            // 
            btnMarcar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMarcar.Location = new Point(331, 15);
            btnMarcar.Name = "btnMarcar";
            btnMarcar.Size = new Size(75, 23);
            btnMarcar.TabIndex = 7;
            btnMarcar.Text = "Marcar";
            btnMarcar.UseVisualStyleBackColor = true;
            btnMarcar.Click += btnMarcar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(32, 15);
            txtId.Name = "txtId";
            txtId.PasswordChar = 'o';
            txtId.Size = new Size(291, 23);
            txtId.TabIndex = 6;
            txtId.TextChanged += txtId_TextChanged;
            txtId.KeyPress += txtId_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 150);
            label1.Name = "label1";
            label1.Size = new Size(575, 45);
            label1.TabIndex = 9;
            label1.Text = "Ingrese su codigo para marcar";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top;
            lblFecha.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(52, 19);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(563, 45);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha";
            lblFecha.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Top;
            lblHora.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.Location = new Point(40, 64);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(575, 84);
            lblHora.TabIndex = 5;
            lblHora.Text = "12:33:60";
            lblHora.TextAlign = ContentAlignment.TopCenter;
            // 
            // gbMarcacion
            // 
            gbMarcacion.Anchor = AnchorStyles.Top;
            gbMarcacion.Controls.Add(label2);
            gbMarcacion.Controls.Add(PicEmpleado);
            gbMarcacion.Controls.Add(lblEmpleado);
            gbMarcacion.Controls.Add(lblSucursalNombre);
            gbMarcacion.Location = new Point(40, 290);
            gbMarcacion.Name = "gbMarcacion";
            gbMarcacion.Size = new Size(562, 157);
            gbMarcacion.TabIndex = 4;
            gbMarcacion.TabStop = false;
            gbMarcacion.Visible = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(28, 27);
            label2.Name = "label2";
            label2.Size = new Size(306, 35);
            label2.TabIndex = 4;
            label2.Text = "Marcacion realizada con exito!";
            // 
            // PicEmpleado
            // 
            PicEmpleado.Image = Properties.Resources.employed_checked;
            PicEmpleado.Location = new Point(421, 27);
            PicEmpleado.Name = "PicEmpleado";
            PicEmpleado.Size = new Size(96, 96);
            PicEmpleado.SizeMode = PictureBoxSizeMode.AutoSize;
            PicEmpleado.TabIndex = 3;
            PicEmpleado.TabStop = false;
            // 
            // lblEmpleado
            // 
            lblEmpleado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpleado.Location = new Point(28, 77);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(366, 65);
            lblEmpleado.TabIndex = 2;
            lblEmpleado.Text = "Nombre del Empleado";
            // 
            // lblSucursalNombre
            // 
            lblSucursalNombre.AutoSize = true;
            lblSucursalNombre.Location = new Point(34, 62);
            lblSucursalNombre.Name = "lblSucursalNombre";
            lblSucursalNombre.Size = new Size(103, 15);
            lblSucursalNombre.TabIndex = 1;
            lblSucursalNombre.Text = "Sucursal Asignada";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 408);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmMarcacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 642);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "FrmMarcacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marcaciones";
            FormClosing += FrmMarcacion_FormClosing;
            Load += FrmMarcacion_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbMarcacion.ResumeLayout(false);
            gbMarcacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicEmpleado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblFecha;
        private Button btnMarcar;
        private TextBox txtId;
        private Label lblHora;
        private GroupBox gbMarcacion;
        private PictureBox PicEmpleado;
        private Label LblNombre;
        private Label lblEmpleado;
        private Label label1;
        private Label lblSucursalNombre;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}