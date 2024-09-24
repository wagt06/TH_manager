namespace MD
{
    partial class FrmGestionDatos
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
            groupBox1 = new GroupBox();
            cboSucursales = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            btnImportar = new Button();
            btnExportar = new Button();
            groupBox2 = new GroupBox();
            chkJustificaciones = new CheckBox();
            chkMarcaciones = new CheckBox();
            lvwDocumentos = new ListView();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnCerrar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cboSucursales);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpFechaFin);
            groupBox1.Controls.Add(dtpFechaInicio);
            groupBox1.Location = new Point(25, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(401, 180);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro Fechas Exportacion";
            // 
            // cboSucursales
            // 
            cboSucursales.FormattingEnabled = true;
            cboSucursales.Location = new Point(139, 115);
            cboSucursales.Margin = new Padding(3, 4, 3, 4);
            cboSucursales.Name = "cboSucursales";
            cboSucursales.Size = new Size(239, 28);
            cboSucursales.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 119);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 8;
            label4.Text = "Sucursal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 75);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha Final:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 33);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 2;
            label1.Text = "Fecha Inicial:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CustomFormat = "yyyy/MM/dd";
            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.ImeMode = ImeMode.NoControl;
            dtpFechaFin.Location = new Point(139, 72);
            dtpFechaFin.Margin = new Padding(3, 4, 3, 4);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(157, 27);
            dtpFechaFin.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CustomFormat = "yyyy/MM/dd";
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.Location = new Point(139, 29);
            dtpFechaInicio.Margin = new Padding(3, 4, 3, 4);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(157, 27);
            dtpFechaInicio.TabIndex = 0;
            // 
            // btnImportar
            // 
            btnImportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnImportar.Image = Properties.Resources.import;
            btnImportar.Location = new Point(25, 578);
            btnImportar.Margin = new Padding(3, 4, 3, 4);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(187, 84);
            btnImportar.TabIndex = 7;
            btnImportar.Text = "Importar";
            btnImportar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportar.Image = Properties.Resources.export;
            btnExportar.Location = new Point(219, 578);
            btnExportar.Margin = new Padding(3, 4, 3, 4);
            btnExportar.Name = "btnExportar";
            btnExportar.Padding = new Padding(0, 0, 11, 0);
            btnExportar.Size = new Size(207, 84);
            btnExportar.TabIndex = 8;
            btnExportar.Text = "Exportar";
            btnExportar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkJustificaciones);
            groupBox2.Controls.Add(chkMarcaciones);
            groupBox2.Location = new Point(25, 204);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(401, 80);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo Datos Exportar";
            // 
            // chkJustificaciones
            // 
            chkJustificaciones.AutoSize = true;
            chkJustificaciones.Location = new Point(209, 28);
            chkJustificaciones.Margin = new Padding(3, 4, 3, 4);
            chkJustificaciones.Name = "chkJustificaciones";
            chkJustificaciones.Size = new Size(125, 24);
            chkJustificaciones.TabIndex = 1;
            chkJustificaciones.Text = "Justificaciones";
            chkJustificaciones.UseVisualStyleBackColor = true;
            // 
            // chkMarcaciones
            // 
            chkMarcaciones.AutoSize = true;
            chkMarcaciones.Location = new Point(80, 29);
            chkMarcaciones.Margin = new Padding(3, 4, 3, 4);
            chkMarcaciones.Name = "chkMarcaciones";
            chkMarcaciones.Size = new Size(114, 24);
            chkMarcaciones.TabIndex = 0;
            chkMarcaciones.Text = "Marcaciones";
            chkMarcaciones.UseVisualStyleBackColor = true;
            // 
            // lvwDocumentos
            // 
            lvwDocumentos.FullRowSelect = true;
            lvwDocumentos.GridLines = true;
            lvwDocumentos.Location = new Point(25, 292);
            lvwDocumentos.Margin = new Padding(3, 4, 3, 4);
            lvwDocumentos.Name = "lvwDocumentos";
            lvwDocumentos.Size = new Size(401, 276);
            lvwDocumentos.TabIndex = 10;
            lvwDocumentos.UseCompatibleStateImageBehavior = false;
            lvwDocumentos.View = View.Details;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Image = Properties.Resources.icons8_close_48;
            btnCerrar.ImageAlign = ContentAlignment.MiddleRight;
            btnCerrar.Location = new Point(306, 670);
            btnCerrar.Margin = new Padding(0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(120, 53);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmGestionDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 739);
            Controls.Add(btnCerrar);
            Controls.Add(lvwDocumentos);
            Controls.Add(groupBox2);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmGestionDatos";
            Text = "Gestion de Datos";
            Load += FrmGestionDatos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboSucursales;
        private Label label4;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Button btnImportar;
        private Button btnExportar;
        private GroupBox groupBox2;
        private CheckBox chkJustificaciones;
        private CheckBox chkMarcaciones;
        private ListView lvwDocumentos;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnCerrar;
    }
}