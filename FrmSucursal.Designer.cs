namespace MD
{
    partial class FrmSucursal
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
            chkActivo = new CheckBox();
            btnGuardar = new Button();
            TxtId = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            btnNuevo = new Button();
            btnCerrar = new Button();
            lwsSucursales = new ListView();
            gbEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // gbEmpleado
            // 
            gbEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gbEmpleado.Controls.Add(chkActivo);
            gbEmpleado.Controls.Add(btnGuardar);
            gbEmpleado.Controls.Add(TxtId);
            gbEmpleado.Controls.Add(label1);
            gbEmpleado.Controls.Add(label3);
            gbEmpleado.Controls.Add(txtNombre);
            gbEmpleado.Location = new Point(12, 12);
            gbEmpleado.Name = "gbEmpleado";
            gbEmpleado.Size = new Size(325, 451);
            gbEmpleado.TabIndex = 15;
            gbEmpleado.TabStop = false;
            gbEmpleado.Text = "Datos del la sucursal";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(25, 292);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 20;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Image = Properties.Resources.icons8_save_48;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(194, 392);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(0, 0, 10, 0);
            btnGuardar.Size = new Size(114, 40);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // TxtId
            // 
            TxtId.BackColor = SystemColors.Info;
            TxtId.Enabled = false;
            TxtId.Location = new Point(25, 59);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(103, 23);
            TxtId.TabIndex = 16;
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
            label3.Size = new Size(20, 15);
            label3.TabIndex = 15;
            label3.Text = "Id:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 112);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(269, 48);
            txtNombre.TabIndex = 12;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevo.Image = Properties.Resources.icons8_add_48;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(660, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Padding = new Padding(0, 0, 10, 0);
            btnNuevo.Size = new Size(110, 32);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Image = Properties.Resources.icons8_close_48;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(683, 423);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(0, 0, 10, 0);
            btnCerrar.Size = new Size(105, 40);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lwsSucursales
            // 
            lwsSucursales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lwsSucursales.FullRowSelect = true;
            lwsSucursales.GridLines = true;
            lwsSucursales.Location = new Point(361, 52);
            lwsSucursales.MultiSelect = false;
            lwsSucursales.Name = "lwsSucursales";
            lwsSucursales.Size = new Size(427, 365);
            lwsSucursales.TabIndex = 12;
            lwsSucursales.UseCompatibleStateImageBehavior = false;
            lwsSucursales.View = View.Details;
            lwsSucursales.Click += lwsSucursales_Click;
            // 
            // FrmSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(gbEmpleado);
            Controls.Add(btnNuevo);
            Controls.Add(btnCerrar);
            Controls.Add(lwsSucursales);
            Name = "FrmSucursal";
            Text = "Sucursales";
            Load += FrmSucursal_Load;
            gbEmpleado.ResumeLayout(false);
            gbEmpleado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbEmpleado;
        private CheckBox chkActivo;
        private Button btnGuardar;
        private TextBox TxtId;
        private Label label1;
        private Label label3;
        private TextBox txtNombre;
        private Button btnNuevo;
        private Button btnCerrar;
        private ListView lwsSucursales;
    }
}