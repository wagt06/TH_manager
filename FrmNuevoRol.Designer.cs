namespace MD
{
    partial class FrmNuevoRol
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
            label4 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            btnCerrar = new Button();
            chkActivo = new CheckBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Image = Properties.Resources.icons8_save_48;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(167, 205);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(0, 0, 10, 0);
            btnGuardar.Size = new Size(114, 36);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 77);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 25;
            label4.Text = "Nombre Rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 28);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 23;
            label2.Text = "Id:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Info;
            txtId.Location = new Point(12, 46);
            txtId.MaxLength = 20;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(106, 23);
            txtId.TabIndex = 19;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Image = Properties.Resources.icons8_close_48;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(56, 205);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(0, 0, 10, 0);
            btnCerrar.Size = new Size(105, 36);
            btnCerrar.TabIndex = 22;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(12, 124);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 20;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 95);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(269, 23);
            txtNombre.TabIndex = 26;
            // 
            // FrmNuevoRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 253);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(btnCerrar);
            Controls.Add(chkActivo);
            Name = "FrmNuevoRol";
            Text = "Nuevo Rol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label label4;
        private Label label2;
        private TextBox txtId;
        private Button btnCerrar;
        private CheckBox chkActivo;
        private TextBox txtNombre;
    }
}