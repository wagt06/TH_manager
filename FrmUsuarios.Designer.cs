﻿namespace MD
{
    partial class FrmUsuarios
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
            gbEmpleado = new GroupBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            txtConfirmarContrasena = new TextBox();
            label7 = new Label();
            txtContraseña = new TextBox();
            label6 = new Label();
            label4 = new Label();
            cboRol = new ComboBox();
            label2 = new Label();
            txtCorreo = new TextBox();
            btnCerrar = new Button();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            TxtId = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            chkActivo = new CheckBox();
            btnNuevo = new Button();
            lwsEmpleados = new ListView();
            label5 = new Label();
            txtBusqueda = new TextBox();
            gbEmpleado.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gbEmpleado
            // 
            gbEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbEmpleado.Controls.Add(panel1);
            gbEmpleado.Location = new Point(634, 13);
            gbEmpleado.Margin = new Padding(3, 4, 3, 4);
            gbEmpleado.Name = "gbEmpleado";
            gbEmpleado.Padding = new Padding(3, 4, 3, 4);
            gbEmpleado.Size = new Size(435, 692);
            gbEmpleado.TabIndex = 4;
            gbEmpleado.TabStop = false;
            gbEmpleado.Text = "Datos del Usuario";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cboRol);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(TxtId);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(chkActivo);
            panel1.Location = new Point(26, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 644);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtConfirmarContrasena);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(15, 268);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 164);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Location = new Point(23, 103);
            txtConfirmarContrasena.Margin = new Padding(3, 4, 3, 4);
            txtConfirmarContrasena.MaxLength = 20;
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PasswordChar = '*';
            txtConfirmarContrasena.Size = new Size(295, 27);
            txtConfirmarContrasena.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 79);
            label7.Name = "label7";
            label7.Size = new Size(153, 20);
            label7.TabIndex = 37;
            label7.Text = "Confirmar Contrasena";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(25, 48);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.MaxLength = 20;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(295, 27);
            txtContraseña.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 24);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 30;
            label6.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 210);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 35;
            label4.Text = "Correo:";
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FormattingEnabled = true;
            cboRol.ItemHeight = 20;
            cboRol.Location = new Point(38, 459);
            cboRol.Margin = new Padding(3, 4, 3, 4);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(295, 28);
            cboRol.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 435);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 32;
            label2.Text = "Rol:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(38, 234);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.MaxLength = 20;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(295, 27);
            txtCorreo.TabIndex = 2;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Image = Properties.Resources.icons8_close_48;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(131, 579);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(0, 0, 11, 0);
            btnCerrar.Size = new Size(120, 51);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 163);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 27);
            txtNombre.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Image = Properties.Resources.icons8_save_48;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(257, 579);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(0, 0, 11, 0);
            btnGuardar.Size = new Size(120, 51);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // TxtId
            // 
            TxtId.BackColor = SystemColors.Info;
            TxtId.Enabled = false;
            TxtId.Location = new Point(38, 93);
            TxtId.Margin = new Padding(3, 4, 3, 4);
            TxtId.Name = "TxtId";
            TxtId.ReadOnly = true;
            TxtId.Size = new Size(117, 27);
            TxtId.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 69);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 15;
            label3.Text = "Codigo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 139);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 11;
            label1.Text = "Nombre Usuario: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_security_pass_96;
            pictureBox1.Location = new Point(267, 69);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(38, 495);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 5;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Image = Properties.Resources.icons8_add_48;
            btnNuevo.Location = new Point(492, 13);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(124, 39);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // lwsEmpleados
            // 
            lwsEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lwsEmpleados.FullRowSelect = true;
            lwsEmpleados.GridLines = true;
            lwsEmpleados.Location = new Point(13, 60);
            lwsEmpleados.Margin = new Padding(3, 4, 3, 4);
            lwsEmpleados.Name = "lwsEmpleados";
            lwsEmpleados.Size = new Size(603, 645);
            lwsEmpleados.TabIndex = 2;
            lwsEmpleados.TabStop = false;
            lwsEmpleados.UseCompatibleStateImageBehavior = false;
            lwsEmpleados.View = View.Details;
            lwsEmpleados.DoubleClick += lwsEmpleados_DoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 22);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 0;
            label5.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(107, 19);
            txtBusqueda.Margin = new Padding(3, 4, 3, 4);
            txtBusqueda.MaxLength = 50;
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(308, 27);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 718);
            Controls.Add(label5);
            Controls.Add(txtBusqueda);
            Controls.Add(gbEmpleado);
            Controls.Add(btnNuevo);
            Controls.Add(lwsEmpleados);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            gbEmpleado.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbEmpleado;
        private Panel panel1;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private TextBox TxtId;
        private Label label6;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox chkActivo;
        private Button btnCerrar;
        private Button btnGuardar;
        private Button btnNuevo;
        private ListView lwsEmpleados;
        private ComboBox cboRol;
        private Label label2;
        private TextBox txtCorreo;
        private Label label4;
        private Label label5;
        private TextBox txtBusqueda;
        private TextBox txtConfirmarContrasena;
        private Label label7;
        private GroupBox groupBox1;
    }
}