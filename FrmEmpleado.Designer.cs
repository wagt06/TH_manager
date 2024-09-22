namespace MD
{
    partial class FrmEmpleado
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
        /// 
        private void InitializeComponent()
        {
            lwsEmpleados = new ListView();
            btnNuevo = new Button();
            gbEmpleado = new GroupBox();
            panel1 = new Panel();
            txtContraseña = new TextBox();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            TxtId = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label7 = new Label();
            label3 = new Label();
            cboHorarios = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            cboSucursal = new ComboBox();
            chkActivo = new CheckBox();
            label4 = new Label();
            btnCerrar = new Button();
            btnGuardar = new Button();
            gbEmpleado.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lwsEmpleados
            // 
            lwsEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lwsEmpleados.FullRowSelect = true;
            lwsEmpleados.GridLines = true;
            lwsEmpleados.Location = new Point(12, 60);
            lwsEmpleados.Margin = new Padding(3, 4, 3, 4);
            lwsEmpleados.Name = "lwsEmpleados";
            lwsEmpleados.Size = new Size(603, 632);
            lwsEmpleados.TabIndex = 11;
            lwsEmpleados.TabStop = false;
            lwsEmpleados.UseCompatibleStateImageBehavior = false;
            lwsEmpleados.View = View.Details;
            lwsEmpleados.Click += lwsEmpleados_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Image = Properties.Resources.icons8_add_48;
            btnNuevo.Location = new Point(11, 13);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(124, 39);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // gbEmpleado
            // 
            gbEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbEmpleado.Controls.Add(panel1);
            gbEmpleado.Controls.Add(btnCerrar);
            gbEmpleado.Controls.Add(btnGuardar);
            gbEmpleado.Location = new Point(633, 13);
            gbEmpleado.Margin = new Padding(3, 4, 3, 4);
            gbEmpleado.Name = "gbEmpleado";
            gbEmpleado.Padding = new Padding(3, 4, 3, 4);
            gbEmpleado.Size = new Size(705, 679);
            gbEmpleado.TabIndex = 1;
            gbEmpleado.TabStop = false;
            gbEmpleado.Text = "Datos del Empleado";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(TxtId);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboHorarios);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cboSucursal);
            panel1.Controls.Add(chkActivo);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(19, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 577);
            panel1.TabIndex = 32;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(29, 418);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.MaxLength = 20;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(305, 27);
            txtContraseña.TabIndex = 29;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(30, 211);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.MaxLength = 20;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(307, 27);
            txtCedula.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 113);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.MaxLength = 50;
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(307, 63);
            txtNombre.TabIndex = 3;
            // 
            // TxtId
            // 
            TxtId.BackColor = SystemColors.Window;
            TxtId.Enabled = false;
            TxtId.Location = new Point(30, 43);
            TxtId.Margin = new Padding(3, 4, 3, 4);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(117, 27);
            TxtId.TabIndex = 2;
            TxtId.KeyPress += TxtId_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 385);
            label6.Name = "label6";
            label6.Size = new Size(165, 20);
            label6.TabIndex = 30;
            label6.Text = "Constraseña marcacion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 187);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 13;
            label2.Text = "Cedula:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 320);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 27;
            label7.Text = "Horario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 19);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 15;
            label3.Text = "Codigo:";
            // 
            // cboHorarios
            // 
            cboHorarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHorarios.FormattingEnabled = true;
            cboHorarios.ItemHeight = 20;
            cboHorarios.Location = new Point(30, 344);
            cboHorarios.Margin = new Padding(3, 4, 3, 4);
            cboHorarios.Name = "cboHorarios";
            cboHorarios.Size = new Size(307, 28);
            cboHorarios.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 89);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 11;
            label1.Text = "Nombres: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_security_pass_96;
            pictureBox1.Location = new Point(234, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // cboSucursal
            // 
            cboSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursal.FormattingEnabled = true;
            cboSucursal.ItemHeight = 20;
            cboSucursal.Location = new Point(30, 276);
            cboSucursal.Margin = new Padding(3, 4, 3, 4);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(307, 28);
            cboSucursal.TabIndex = 17;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(30, 470);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 8;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 252);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 18;
            label4.Text = "Sucursal:";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Image = Properties.Resources.icons8_close_48;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(444, 620);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(0, 0, 11, 0);
            btnCerrar.Size = new Size(120, 51);
            btnCerrar.TabIndex = 31;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Image = Properties.Resources.icons8_save_48;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(570, 620);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(0, 0, 11, 0);
            btnGuardar.Size = new Size(120, 51);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 717);
            Controls.Add(gbEmpleado);
            Controls.Add(btnNuevo);
            Controls.Add(lwsEmpleados);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEmpleado";
            Text = "Empleado";
            gbEmpleado.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListView lwsEmpleados;
        private Button btnNuevo;
        private GroupBox gbEmpleado;
        private Label label4;
        private ComboBox cboSucursal;
        private TextBox TxtId;
        private Label label3;
        private TextBox txtCedula;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Button btnGuardar;
        private CheckBox chkActivo;
        private PictureBox pictureBox1;
        private Label label7;
        private ComboBox cboHorarios;
        private TextBox txtContraseña;
        private Label label6;
        private Button btnCerrar;
        private Panel panel1;
    }
}