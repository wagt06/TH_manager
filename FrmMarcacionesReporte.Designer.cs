namespace MD
{
    partial class FrmMarcacionesReporte
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
            label3 = new Label();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            lswDatosMarcaciones = new ListView();
            btnCerrar = new Button();
            btnExportar = new Button();
            btnImportar = new Button();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            tbDocumentos = new TabControl();
            tabPage1 = new TabPage();
            groupBox1.SuspendLayout();
            tbDocumentos.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cboSucursales);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBusqueda);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpFechaFin);
            groupBox1.Controls.Add(dtpFechaInicio);
            groupBox1.Location = new Point(15, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1032, 84);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro";
            // 
            // cboSucursales
            // 
            cboSucursales.FormattingEnabled = true;
            cboSucursales.Location = new Point(416, 53);
            cboSucursales.Name = "cboSucursales";
            cboSucursales.Size = new Size(333, 23);
            cboSucursales.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(338, 56);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Sucursal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 22);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombre:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(416, 20);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(333, 23);
            txtBusqueda.TabIndex = 6;
            txtBusqueda.KeyPress += txtBusqueda_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscar.Image = Properties.Resources.search2_more_48;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(891, 26);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Padding = new Padding(0, 0, 10, 0);
            btnBuscar.Size = new Size(105, 40);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
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
            // lswDatosMarcaciones
            // 
            lswDatosMarcaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lswDatosMarcaciones.FullRowSelect = true;
            lswDatosMarcaciones.GridLines = true;
            lswDatosMarcaciones.Location = new Point(3, 6);
            lswDatosMarcaciones.Name = "lswDatosMarcaciones";
            lswDatosMarcaciones.Size = new Size(1012, 410);
            lswDatosMarcaciones.TabIndex = 1;
            lswDatosMarcaciones.UseCompatibleStateImageBehavior = false;
            lswDatosMarcaciones.View = View.Details;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Image = Properties.Resources.icons8_close_48;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(942, 551);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(0, 0, 10, 0);
            btnCerrar.Size = new Size(105, 40);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportar.Image = Properties.Resources.excel_48;
            btnExportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportar.Location = new Point(755, 551);
            btnExportar.Name = "btnExportar";
            btnExportar.Padding = new Padding(0, 0, 10, 0);
            btnExportar.Size = new Size(181, 40);
            btnExportar.TabIndex = 5;
            btnExportar.Text = "Copiar en Portapapeles";
            btnExportar.TextAlign = ContentAlignment.MiddleRight;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnImportar
            // 
            btnImportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnImportar.Image = Properties.Resources.ftp_server_48;
            btnImportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnImportar.Location = new Point(21, 551);
            btnImportar.Name = "btnImportar";
            btnImportar.Padding = new Padding(0, 0, 10, 0);
            btnImportar.Size = new Size(156, 40);
            btnImportar.TabIndex = 6;
            btnImportar.Text = "Importar | Exportar";
            btnImportar.TextAlign = ContentAlignment.MiddleRight;
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbDocumentos
            // 
            tbDocumentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDocumentos.Controls.Add(tabPage1);
            tbDocumentos.Location = new Point(17, 95);
            tbDocumentos.Name = "tbDocumentos";
            tbDocumentos.SelectedIndex = 0;
            tbDocumentos.Size = new Size(1029, 450);
            tbDocumentos.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lswDatosMarcaciones);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1021, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Marcaciones";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // FrmMarcacionesReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 603);
            Controls.Add(tbDocumentos);
            Controls.Add(btnImportar);
            Controls.Add(btnExportar);
            Controls.Add(btnCerrar);
            Controls.Add(groupBox1);
            Name = "FrmMarcacionesReporte";
            Text = "Reporte Marcaciones";
            Load += FrmMarcacionesReporte_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tbDocumentos.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lswDatosMarcaciones;
        private Button btnCerrar;
        private Button btnBuscar;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Button btnExportar;
        private Button btnImportar;
        private Label label3;
        private TextBox txtBusqueda;
        private ComboBox cboSucursales;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TabControl tbDocumentos;
        private TabPage tabPage1;
    }
}