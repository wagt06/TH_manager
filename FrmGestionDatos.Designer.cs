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
            btnBuscar = new Button();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cboSucursales);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpFechaFin);
            groupBox1.Controls.Add(dtpFechaInicio);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 135);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro";
            // 
            // cboSucursales
            // 
            cboSucursales.FormattingEnabled = true;
            cboSucursales.Location = new Point(122, 86);
            cboSucursales.Name = "cboSucursales";
            cboSucursales.Size = new Size(210, 23);
            cboSucursales.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 89);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Sucursal:";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscar.Image = Properties.Resources.search2_more_48;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(1042, 61);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Padding = new Padding(0, 0, 10, 0);
            btnBuscar.Size = new Size(105, 40);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha Final:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Fecha Inicial:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CustomFormat = "yyyy/MM/dd";
            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.ImeMode = ImeMode.NoControl;
            dtpFechaFin.Location = new Point(122, 54);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(138, 23);
            dtpFechaFin.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CustomFormat = "yyyy/MM/dd";
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.Location = new Point(122, 22);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(138, 23);
            dtpFechaInicio.TabIndex = 0;
            // 
            // btnImportar
            // 
            btnImportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnImportar.Image = Properties.Resources.excel_48;
            btnImportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnImportar.Location = new Point(22, 433);
            btnImportar.Name = "btnImportar";
            btnImportar.Padding = new Padding(0, 0, 10, 0);
            btnImportar.Size = new Size(107, 40);
            btnImportar.TabIndex = 7;
            btnImportar.Text = "Importar";
            btnImportar.TextAlign = ContentAlignment.MiddleRight;
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportar.Image = Properties.Resources.ftp_server_48;
            btnExportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportar.Location = new Point(269, 433);
            btnExportar.Name = "btnExportar";
            btnExportar.Padding = new Padding(0, 0, 10, 0);
            btnExportar.Size = new Size(104, 40);
            btnExportar.TabIndex = 8;
            btnExportar.Text = "Exportar";
            btnExportar.TextAlign = ContentAlignment.MiddleRight;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkJustificaciones);
            groupBox2.Controls.Add(chkMarcaciones);
            groupBox2.Location = new Point(22, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(351, 60);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "TipoDatos";
            // 
            // chkJustificaciones
            // 
            chkJustificaciones.AutoSize = true;
            chkJustificaciones.Location = new Point(129, 21);
            chkJustificaciones.Name = "chkJustificaciones";
            chkJustificaciones.Size = new Size(102, 19);
            chkJustificaciones.TabIndex = 1;
            chkJustificaciones.Text = "Justificaciones";
            chkJustificaciones.UseVisualStyleBackColor = true;
            // 
            // chkMarcaciones
            // 
            chkMarcaciones.AutoSize = true;
            chkMarcaciones.Location = new Point(16, 22);
            chkMarcaciones.Name = "chkMarcaciones";
            chkMarcaciones.Size = new Size(93, 19);
            chkMarcaciones.TabIndex = 0;
            chkMarcaciones.Text = "Marcaciones";
            chkMarcaciones.UseVisualStyleBackColor = true;
            // 
            // lvwDocumentos
            // 
            lvwDocumentos.FullRowSelect = true;
            lvwDocumentos.GridLines = true;
            lvwDocumentos.Location = new Point(22, 219);
            lvwDocumentos.Name = "lvwDocumentos";
            lvwDocumentos.Size = new Size(351, 208);
            lvwDocumentos.TabIndex = 10;
            lvwDocumentos.UseCompatibleStateImageBehavior = false;
            lvwDocumentos.View = View.Details;
            // 
            // FrmGestionDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 485);
            Controls.Add(lvwDocumentos);
            Controls.Add(groupBox2);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(groupBox1);
            Name = "FrmGestionDatos";
            Text = "FrmGestionDatos";
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
        private Button btnBuscar;
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
    }
}