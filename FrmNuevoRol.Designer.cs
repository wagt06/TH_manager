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
            btnGuardar.Location = new Point(191, 273);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(0, 0, 11, 0);
            btnGuardar.Size = new Size(130, 48);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 103);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 25;
            label4.Text = "Nombre Rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 37);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 23;
            label2.Text = "Id:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Info;
            txtId.Location = new Point(14, 61);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.MaxLength = 20;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(121, 27);
            txtId.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Image = Properties.Resources.icons8_close_48;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(64, 273);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(0, 0, 11, 0);
            btnCerrar.Size = new Size(120, 48);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(14, 165);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 2;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(14, 127);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(307, 27);
            txtNombre.TabIndex = 1;
            // 
            // FrmNuevoRol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 337);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(btnCerrar);
            Controls.Add(chkActivo);
            Margin = new Padding(3, 4, 3, 4);
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