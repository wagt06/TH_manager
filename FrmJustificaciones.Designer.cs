namespace MD
{
    partial class FrmJustificaciones
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
            label4 = new Label();
            cboTipoJustificaciones = new ComboBox();
            TxtIdEmpleado = new TextBox();
            lblObservaciones = new Label();
            label3 = new Label();
            label2 = new Label();
            txtObservaciones = new TextBox();
            cboEstadoJustificaciones = new ComboBox();
            label1 = new Label();
            btnNuevo = new Button();
            btnCerrar = new Button();
            lwsJustificaciones = new ListView();
            btnGuardar = new Button();
            gbEmpleado = new GroupBox();
            label11 = new Label();
            rdHoraExtra = new RadioButton();
            rdPermiso = new RadioButton();
            txtCodigoJustificacion = new TextBox();
            txtNombre = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            chkIsFeriado = new CheckBox();
            txtHoras = new TextBox();
            CalendarDias = new MonthCalendar();
            label10 = new Label();
            dtpFin = new DateTimePicker();
            label6 = new Label();
            dtpInicio = new DateTimePicker();
            btnBuscarEmpleado = new Button();
            btnGuardarJust = new Button();
            groupBox2 = new GroupBox();
            chkSoloEmpleado = new CheckBox();
            btnFiltroBuscar = new Button();
            ChkPendientes = new CheckBox();
            dtpFechaFinal = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            dtpFechaInicial = new DateTimePicker();
            gbEmpleado.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 24);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 29;
            label4.Text = "Inicio:";
            // 
            // cboTipoJustificaciones
            // 
            cboTipoJustificaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoJustificaciones.FormattingEnabled = true;
            cboTipoJustificaciones.ItemHeight = 15;
            cboTipoJustificaciones.Location = new Point(15, 237);
            cboTipoJustificaciones.Name = "cboTipoJustificaciones";
            cboTipoJustificaciones.Size = new Size(316, 23);
            cboTipoJustificaciones.TabIndex = 28;
            // 
            // TxtIdEmpleado
            // 
            TxtIdEmpleado.BackColor = SystemColors.Info;
            TxtIdEmpleado.Enabled = false;
            TxtIdEmpleado.Location = new Point(19, 116);
            TxtIdEmpleado.Name = "TxtIdEmpleado";
            TxtIdEmpleado.Size = new Size(64, 23);
            TxtIdEmpleado.TabIndex = 22;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Location = new Point(15, 143);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(87, 15);
            lblObservaciones.TabIndex = 25;
            lblObservaciones.Text = "Observaciones:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 27);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 27;
            label3.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 219);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 26;
            label2.Text = "Tipo Justificacion:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(15, 161);
            txtObservaciones.MaxLength = 50;
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(384, 48);
            txtObservaciones.TabIndex = 23;
            // 
            // cboEstadoJustificaciones
            // 
            cboEstadoJustificaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoJustificaciones.FormattingEnabled = true;
            cboEstadoJustificaciones.ItemHeight = 15;
            cboEstadoJustificaciones.Location = new Point(70, 484);
            cboEstadoJustificaciones.Name = "cboEstadoJustificaciones";
            cboEstadoJustificaciones.Size = new Size(176, 23);
            cboEstadoJustificaciones.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 490);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 35;
            label1.Text = "Estado:";
            // 
            // btnNuevo
            // 
            btnNuevo.Image = Properties.Resources.icons8_add_48;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(462, 14);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Padding = new Padding(0, 0, 10, 0);
            btnNuevo.Size = new Size(110, 38);
            btnNuevo.TabIndex = 39;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += BtnNuevo_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Image = Properties.Resources.icons8_close_48;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(1200, 553);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(0, 0, 10, 0);
            btnCerrar.Size = new Size(105, 40);
            btnCerrar.TabIndex = 38;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lwsJustificaciones
            // 
            lwsJustificaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lwsJustificaciones.FullRowSelect = true;
            lwsJustificaciones.GridLines = true;
            lwsJustificaciones.Location = new Point(462, 128);
            lwsJustificaciones.MultiSelect = false;
            lwsJustificaciones.Name = "lwsJustificaciones";
            lwsJustificaciones.Size = new Size(843, 420);
            lwsJustificaciones.TabIndex = 37;
            lwsJustificaciones.UseCompatibleStateImageBehavior = false;
            lwsJustificaciones.View = View.Details;
            lwsJustificaciones.DoubleClick += LwsJustificaciones_DoubleClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Image = Properties.Resources.icons8_save_48;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(436, 899);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(0, 0, 10, 0);
            btnGuardar.Size = new Size(114, 40);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // gbEmpleado
            // 
            gbEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gbEmpleado.Controls.Add(label11);
            gbEmpleado.Controls.Add(rdHoraExtra);
            gbEmpleado.Controls.Add(rdPermiso);
            gbEmpleado.Controls.Add(txtCodigoJustificacion);
            gbEmpleado.Controls.Add(txtNombre);
            gbEmpleado.Controls.Add(label9);
            gbEmpleado.Controls.Add(groupBox1);
            gbEmpleado.Controls.Add(btnBuscarEmpleado);
            gbEmpleado.Controls.Add(btnGuardarJust);
            gbEmpleado.Controls.Add(btnGuardar);
            gbEmpleado.Controls.Add(cboTipoJustificaciones);
            gbEmpleado.Controls.Add(txtObservaciones);
            gbEmpleado.Controls.Add(label2);
            gbEmpleado.Controls.Add(cboEstadoJustificaciones);
            gbEmpleado.Controls.Add(label3);
            gbEmpleado.Controls.Add(label1);
            gbEmpleado.Controls.Add(lblObservaciones);
            gbEmpleado.Controls.Add(TxtIdEmpleado);
            gbEmpleado.Location = new Point(19, 10);
            gbEmpleado.Name = "gbEmpleado";
            gbEmpleado.Padding = new Padding(3, 3, 9, 3);
            gbEmpleado.Size = new Size(423, 583);
            gbEmpleado.TabIndex = 40;
            gbEmpleado.TabStop = false;
            gbEmpleado.Text = "Justificacion Empleado";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(224, 30);
            label11.Name = "label11";
            label11.Size = new Size(114, 15);
            label11.TabIndex = 50;
            label11.Text = "Tipo de Justificacion";
            // 
            // rdHoraExtra
            // 
            rdHoraExtra.Appearance = Appearance.Button;
            rdHoraExtra.BackgroundImageLayout = ImageLayout.None;
            rdHoraExtra.CheckAlign = ContentAlignment.TopCenter;
            rdHoraExtra.Checked = true;
            rdHoraExtra.FlatStyle = FlatStyle.System;
            rdHoraExtra.Location = new Point(299, 50);
            rdHoraExtra.Margin = new Padding(3, 2, 3, 2);
            rdHoraExtra.Name = "rdHoraExtra";
            rdHoraExtra.Size = new Size(99, 34);
            rdHoraExtra.TabIndex = 49;
            rdHoraExtra.TabStop = true;
            rdHoraExtra.Text = "Horas Extras";
            rdHoraExtra.TextAlign = ContentAlignment.MiddleCenter;
            rdHoraExtra.UseVisualStyleBackColor = true;
            rdHoraExtra.CheckedChanged += RdHoraExtra_CheckedChanged;
            // 
            // rdPermiso
            // 
            rdPermiso.Appearance = Appearance.Button;
            rdPermiso.BackgroundImageLayout = ImageLayout.None;
            rdPermiso.CheckAlign = ContentAlignment.TopCenter;
            rdPermiso.FlatStyle = FlatStyle.System;
            rdPermiso.Location = new Point(181, 50);
            rdPermiso.Margin = new Padding(3, 2, 3, 2);
            rdPermiso.Name = "rdPermiso";
            rdPermiso.Size = new Size(102, 34);
            rdPermiso.TabIndex = 48;
            rdPermiso.Text = "Permiso";
            rdPermiso.TextAlign = ContentAlignment.MiddleCenter;
            rdPermiso.UseVisualStyleBackColor = true;
            rdPermiso.CheckedChanged += RdPermiso_CheckedChanged;
            // 
            // txtCodigoJustificacion
            // 
            txtCodigoJustificacion.BackColor = SystemColors.Info;
            txtCodigoJustificacion.Enabled = false;
            txtCodigoJustificacion.Location = new Point(42, 25);
            txtCodigoJustificacion.Name = "txtCodigoJustificacion";
            txtCodigoJustificacion.Size = new Size(64, 23);
            txtCodigoJustificacion.TabIndex = 47;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Info;
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(95, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 23);
            txtNombre.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 98);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 45;
            label9.Text = "Empleado";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkIsFeriado);
            groupBox1.Controls.Add(txtHoras);
            groupBox1.Controls.Add(CalendarDias);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtpFin);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpInicio);
            groupBox1.Location = new Point(15, 263);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(393, 215);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Periodo";
            // 
            // chkIsFeriado
            // 
            chkIsFeriado.AutoSize = true;
            chkIsFeriado.Location = new Point(10, 188);
            chkIsFeriado.Margin = new Padding(3, 2, 3, 2);
            chkIsFeriado.Name = "chkIsFeriado";
            chkIsFeriado.Size = new Size(85, 19);
            chkIsFeriado.TabIndex = 49;
            chkIsFeriado.Text = "Dia Feriado";
            chkIsFeriado.UseVisualStyleBackColor = true;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(279, 157);
            txtHoras.MaxLength = 50;
            txtHoras.Multiline = true;
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(72, 24);
            txtHoras.TabIndex = 47;
            // 
            // CalendarDias
            // 
            CalendarDias.Location = new Point(10, 24);
            CalendarDias.Margin = new Padding(8, 7, 8, 7);
            CalendarDias.Name = "CalendarDias";
            CalendarDias.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(279, 126);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 48;
            label10.Text = "Horas:";
            // 
            // dtpFin
            // 
            dtpFin.Checked = false;
            dtpFin.CustomFormat = "hh:mm:ss";
            dtpFin.Format = DateTimePickerFormat.Time;
            dtpFin.Location = new Point(279, 96);
            dtpFin.Margin = new Padding(3, 2, 3, 2);
            dtpFin.Name = "dtpFin";
            dtpFin.RightToLeft = RightToLeft.Yes;
            dtpFin.ShowUpDown = true;
            dtpFin.Size = new Size(98, 23);
            dtpFin.TabIndex = 39;
            dtpFin.Value = new DateTime(2024, 8, 16, 23, 28, 0, 0);
            dtpFin.ValueChanged += DtpFin_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 79);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 40;
            label6.Text = "Finaliza:";
            // 
            // dtpInicio
            // 
            dtpInicio.Checked = false;
            dtpInicio.CustomFormat = "hh:mm:ss";
            dtpInicio.Format = DateTimePickerFormat.Time;
            dtpInicio.Location = new Point(279, 44);
            dtpInicio.Margin = new Padding(3, 2, 3, 2);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.ShowUpDown = true;
            dtpInicio.Size = new Size(101, 23);
            dtpInicio.TabIndex = 38;
            dtpInicio.ValueChanged += DtpInicio_ValueChanged;
            // 
            // btnBuscarEmpleado
            // 
            btnBuscarEmpleado.Location = new Point(341, 115);
            btnBuscarEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            btnBuscarEmpleado.Size = new Size(34, 22);
            btnBuscarEmpleado.TabIndex = 46;
            btnBuscarEmpleado.Text = "...";
            btnBuscarEmpleado.UseVisualStyleBackColor = true;
            btnBuscarEmpleado.Click += BtnBuscarEmpleado_Click;
            // 
            // btnGuardarJust
            // 
            btnGuardarJust.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarJust.Image = Properties.Resources.icons8_save_48;
            btnGuardarJust.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarJust.Location = new Point(288, 537);
            btnGuardarJust.Name = "btnGuardarJust";
            btnGuardarJust.Padding = new Padding(0, 0, 10, 0);
            btnGuardarJust.Size = new Size(114, 40);
            btnGuardarJust.TabIndex = 37;
            btnGuardarJust.Text = "Guardar";
            btnGuardarJust.TextAlign = ContentAlignment.MiddleRight;
            btnGuardarJust.UseVisualStyleBackColor = true;
            btnGuardarJust.Click += BtnGuardar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkSoloEmpleado);
            groupBox2.Controls.Add(btnFiltroBuscar);
            groupBox2.Controls.Add(ChkPendientes);
            groupBox2.Controls.Add(dtpFechaFinal);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dtpFechaInicial);
            groupBox2.Location = new Point(462, 57);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(843, 62);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "Periodo";
            // 
            // chkSoloEmpleado
            // 
            chkSoloEmpleado.AutoSize = true;
            chkSoloEmpleado.Location = new Point(409, 27);
            chkSoloEmpleado.Margin = new Padding(3, 2, 3, 2);
            chkSoloEmpleado.Name = "chkSoloEmpleado";
            chkSoloEmpleado.Size = new Size(124, 19);
            chkSoloEmpleado.TabIndex = 44;
            chkSoloEmpleado.Text = "Solo del Empleado";
            chkSoloEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnFiltroBuscar
            // 
            btnFiltroBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltroBuscar.Image = Properties.Resources.search2_more_48;
            btnFiltroBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltroBuscar.Location = new Point(709, 16);
            btnFiltroBuscar.Name = "btnFiltroBuscar";
            btnFiltroBuscar.Padding = new Padding(0, 0, 10, 0);
            btnFiltroBuscar.Size = new Size(110, 38);
            btnFiltroBuscar.TabIndex = 43;
            btnFiltroBuscar.Text = "Buscar";
            btnFiltroBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnFiltroBuscar.UseVisualStyleBackColor = true;
            btnFiltroBuscar.Click += button2_Click;
            // 
            // ChkPendientes
            // 
            ChkPendientes.AutoSize = true;
            ChkPendientes.Location = new Point(586, 28);
            ChkPendientes.Margin = new Padding(3, 2, 3, 2);
            ChkPendientes.Name = "ChkPendientes";
            ChkPendientes.Size = new Size(79, 19);
            ChkPendientes.TabIndex = 41;
            ChkPendientes.Text = "Pendiente";
            ChkPendientes.UseVisualStyleBackColor = true;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.CustomFormat = "yyyy/MM/dd ";
            dtpFechaFinal.Format = DateTimePickerFormat.Custom;
            dtpFechaFinal.Location = new Point(275, 26);
            dtpFechaFinal.Margin = new Padding(3, 2, 3, 2);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(114, 23);
            dtpFechaFinal.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(206, 28);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 40;
            label7.Text = "Finaliza:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 28);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 29;
            label8.Text = "Inicio:";
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.CustomFormat = "yyyy/MM/dd";
            dtpFechaInicial.Format = DateTimePickerFormat.Custom;
            dtpFechaInicial.Location = new Point(71, 26);
            dtpFechaInicial.Margin = new Padding(3, 2, 3, 2);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(116, 23);
            dtpFechaInicial.TabIndex = 38;
            // 
            // FrmJustificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 602);
            Controls.Add(groupBox2);
            Controls.Add(gbEmpleado);
            Controls.Add(btnNuevo);
            Controls.Add(btnCerrar);
            Controls.Add(lwsJustificaciones);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmJustificaciones";
            Text = "Justificaciones empleados";
            Load += FrmJustificaciones_Load;
            gbEmpleado.ResumeLayout(false);
            gbEmpleado.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private ComboBox cboTipoJustificaciones;
        private TextBox TxtIdEmpleado;
        private Label lblObservaciones;
        private Label label3;
        private Label label2;
        private TextBox txtObservaciones;
        private TextBox textBox1;
        private Label label5;
        private Button btnBuscar;
        private ComboBox cboEstadoJustificaciones;
        private Label label1;
        private Button btnNuevo;
        private Button btnCerrar;
        private ListView lwsJustificaciones;
        private Button btnGuardar;
        private GroupBox gbEmpleado;
        private Button btnGuardarJust;
        private GroupBox groupBox1;
        private DateTimePicker dtpFin;
        private Label label6;
        private DateTimePicker dtpInicio;
        private GroupBox groupBox2;
        private CheckBox ChkPendientes;
        private DateTimePicker dtpFechaFinal;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpFechaInicial;
        private TextBox txtNombre;
        private Label label9;
        private Button btnBuscarEmpleado;
        private Button btnFiltroBuscar;
        private CheckBox chkIsFeriado;
        private TextBox txtHoras;
        private Label label10;
        private MonthCalendar CalendarDias;
        private TextBox textBox2;
        private RadioButton rdPermiso;
        private RadioButton rdHoraExtra;
        private Label label11;
        private TextBox txtCodigoJustificacion;
        private CheckBox chkSoloEmpleado;
    }
}