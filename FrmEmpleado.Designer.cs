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
            btnCerrar = new Button();
            btnNuevo = new Button();
            gbEmpleado = new GroupBox();
            gbUsuario = new GroupBox();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cboHorarios = new ComboBox();
            chkUsuario = new CheckBox();
            pictureBox1 = new PictureBox();
            chkActivo = new CheckBox();
            btnGuardar = new Button();
            label4 = new Label();
            cboSucursal = new ComboBox();
            TxtId = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            gbEmpleado.SuspendLayout();
            gbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lwsEmpleados
            // 
            lwsEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lwsEmpleados.FullRowSelect = true;
            lwsEmpleados.GridLines = true;
            lwsEmpleados.Location = new Point(360, 56);
            lwsEmpleados.Name = "lwsEmpleados";
            lwsEmpleados.Size = new Size(532, 496);
            lwsEmpleados.TabIndex = 11;
            lwsEmpleados.TabStop = false;
            lwsEmpleados.UseCompatibleStateImageBehavior = false;
            lwsEmpleados.View = View.Details;
            lwsEmpleados.Click += lwsEmpleados_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Image = Properties.Resources.icons8_close_48;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(787, 558);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(0, 0, 10, 0);
            btnCerrar.Size = new Size(105, 40);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevo.Image = Properties.Resources.icons8_add_48;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(360, 21);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Padding = new Padding(0, 0, 10, 0);
            btnNuevo.Size = new Size(105, 29);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // gbEmpleado
            // 
            gbEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gbEmpleado.Controls.Add(gbUsuario);
            gbEmpleado.Controls.Add(label7);
            gbEmpleado.Controls.Add(cboHorarios);
            gbEmpleado.Controls.Add(chkUsuario);
            gbEmpleado.Controls.Add(pictureBox1);
            gbEmpleado.Controls.Add(chkActivo);
            gbEmpleado.Controls.Add(btnGuardar);
            gbEmpleado.Controls.Add(label4);
            gbEmpleado.Controls.Add(cboSucursal);
            gbEmpleado.Controls.Add(TxtId);
            gbEmpleado.Controls.Add(label1);
            gbEmpleado.Controls.Add(label3);
            gbEmpleado.Controls.Add(label2);
            gbEmpleado.Controls.Add(txtNombre);
            gbEmpleado.Controls.Add(txtCedula);
            gbEmpleado.Location = new Point(12, 12);
            gbEmpleado.Name = "gbEmpleado";
            gbEmpleado.Size = new Size(325, 586);
            gbEmpleado.TabIndex = 1;
            gbEmpleado.TabStop = false;
            gbEmpleado.Text = "Datos del Empleado";
            // 
            // gbUsuario
            // 
            gbUsuario.Controls.Add(txtContraseña);
            gbUsuario.Controls.Add(txtUsuario);
            gbUsuario.Controls.Add(label5);
            gbUsuario.Controls.Add(label6);
            gbUsuario.Location = new Point(25, 360);
            gbUsuario.Name = "gbUsuario";
            gbUsuario.Size = new Size(269, 145);
            gbUsuario.TabIndex = 28;
            gbUsuario.TabStop = false;
            gbUsuario.Text = "Datos del Sistema";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(19, 99);
            txtContraseña.MaxLength = 20;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(203, 23);
            txtContraseña.TabIndex = 7;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(19, 50);
            txtUsuario.MaxLength = 20;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(203, 23);
            txtUsuario.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 32);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 22;
            label5.Text = "Usuario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 81);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 24;
            label6.Text = "Constraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 267);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 27;
            label7.Text = "Horario:";
            // 
            // cboHorarios
            // 
            cboHorarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHorarios.FormattingEnabled = true;
            cboHorarios.ItemHeight = 15;
            cboHorarios.Location = new Point(25, 285);
            cboHorarios.Name = "cboHorarios";
            cboHorarios.Size = new Size(269, 23);
            cboHorarios.TabIndex = 26;
            // 
            // chkUsuario
            // 
            chkUsuario.AutoSize = true;
            chkUsuario.Location = new Point(27, 335);
            chkUsuario.Name = "chkUsuario";
            chkUsuario.Size = new Size(110, 19);
            chkUsuario.TabIndex = 25;
            chkUsuario.Text = "Usuario Sistema";
            chkUsuario.UseVisualStyleBackColor = true;
            chkUsuario.CheckedChanged += chkUsuario_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_security_pass_96;
            pictureBox1.Location = new Point(169, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(27, 534);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 8;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Image = Properties.Resources.icons8_save_48;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(189, 534);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(0, 0, 10, 0);
            btnGuardar.Size = new Size(114, 36);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 216);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 18;
            label4.Text = "Sucursal:";
            // 
            // cboSucursal
            // 
            cboSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursal.FormattingEnabled = true;
            cboSucursal.ItemHeight = 15;
            cboSucursal.Location = new Point(25, 234);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(269, 23);
            cboSucursal.TabIndex = 17;
            // 
            // TxtId
            // 
            TxtId.BackColor = SystemColors.Window;
            TxtId.Enabled = false;
            TxtId.Location = new Point(25, 59);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(103, 23);
            TxtId.TabIndex = 2;
            TxtId.KeyPress += TxtId_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 94);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 11;
            label1.Text = "Nombres: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 41);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 15;
            label3.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 167);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 13;
            label2.Text = "Cedula:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 112);
            txtNombre.MaxLength = 50;
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(269, 48);
            txtNombre.TabIndex = 3;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(25, 185);
            txtCedula.MaxLength = 20;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(269, 23);
            txtCedula.TabIndex = 4;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 610);
            Controls.Add(gbEmpleado);
            Controls.Add(btnNuevo);
            Controls.Add(btnCerrar);
            Controls.Add(lwsEmpleados);
            Name = "FrmEmpleado";
            Text = "Empleado";
            gbEmpleado.ResumeLayout(false);
            gbEmpleado.PerformLayout();
            gbUsuario.ResumeLayout(false);
            gbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListView lwsEmpleados;
        private Button btnCerrar;
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
        private Label label6;
        private TextBox txtContraseña;
        private Label label5;
        private TextBox txtUsuario;
        private CheckBox chkUsuario;
        private Label label7;
        private ComboBox cboHorarios;
        private GroupBox gbUsuario;
    }
}