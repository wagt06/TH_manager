namespace MD
{
    partial class frmBuscador
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
            lwsDatos = new ListView();
            btnCerrar = new Button();
            groupBox1 = new GroupBox();
            gbFechas = new GroupBox();
            Inicial = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            cmdBuscar = new Button();
            txtBusqueda = new TextBox();
            groupBox1.SuspendLayout();
            gbFechas.SuspendLayout();
            SuspendLayout();
            // 
            // lwsDatos
            // 
            lwsDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lwsDatos.FullRowSelect = true;
            lwsDatos.GridLines = true;
            lwsDatos.Location = new Point(21, 149);
            lwsDatos.Margin = new Padding(3, 4, 3, 4);
            lwsDatos.MultiSelect = false;
            lwsDatos.Name = "lwsDatos";
            lwsDatos.Size = new Size(1011, 584);
            lwsDatos.TabIndex = 13;
            lwsDatos.UseCompatibleStateImageBehavior = false;
            lwsDatos.View = View.Details;
            lwsDatos.SelectedIndexChanged += lwsDatos_SelectedIndexChanged;
            lwsDatos.DoubleClick += lwsDatos_DoubleClick;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Image = Properties.Resources.icons8_close_48;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(882, 751);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(0, 0, 11, 0);
            btnCerrar.Size = new Size(150, 53);
            btnCerrar.TabIndex = 20;
            btnCerrar.Text = "Cancelar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gbFechas);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmdBuscar);
            groupBox1.Controls.Add(txtBusqueda);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1011, 121);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // gbFechas
            // 
            gbFechas.BackgroundImageLayout = ImageLayout.None;
            gbFechas.Controls.Add(Inicial);
            gbFechas.Controls.Add(label2);
            gbFechas.Controls.Add(dateTimePicker1);
            gbFechas.Controls.Add(dateTimePicker2);
            gbFechas.Location = new Point(475, 14);
            gbFechas.Name = "gbFechas";
            gbFechas.Size = new Size(331, 97);
            gbFechas.TabIndex = 29;
            gbFechas.TabStop = false;
            // 
            // Inicial
            // 
            Inicial.AutoSize = true;
            Inicial.Location = new Point(19, 23);
            Inicial.Name = "Inicial";
            Inicial.Size = new Size(51, 20);
            Inicial.TabIndex = 27;
            Inicial.Text = "Inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 63);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 28;
            label2.Text = "Final:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(86, 23);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(193, 27);
            dateTimePicker1.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Checked = false;
            dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(86, 58);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(193, 27);
            dateTimePicker2.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 24;
            label1.Text = "Escriba el Parametro a Buscar";
            // 
            // cmdBuscar
            // 
            cmdBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmdBuscar.Image = Properties.Resources.search2_more_48;
            cmdBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            cmdBuscar.Location = new Point(832, 42);
            cmdBuscar.Margin = new Padding(3, 4, 3, 4);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Padding = new Padding(0, 0, 11, 0);
            cmdBuscar.Size = new Size(116, 53);
            cmdBuscar.TabIndex = 23;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.TextAlign = ContentAlignment.MiddleRight;
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(20, 58);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(419, 27);
            txtBusqueda.TabIndex = 0;
            // 
            // frmBuscador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 817);
            Controls.Add(groupBox1);
            Controls.Add(btnCerrar);
            Controls.Add(lwsDatos);
            Name = "frmBuscador";
            Text = "frmBuscador";
            Load += frmBuscador_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbFechas.ResumeLayout(false);
            gbFechas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView lwsDatos;
        private Button btnCerrar;
        private GroupBox groupBox1;
        private Button cmdBuscar;
        private TextBox txtBusqueda;
        private Label label2;
        private Label Inicial;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private GroupBox gbFechas;
    }
}