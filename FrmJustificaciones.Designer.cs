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
            lblObservaciones = new Label();
            label3 = new Label();
            label2 = new Label();
            txtObservaciones = new TextBox();
            btnNuevo = new Button();
            btnCerrar = new Button();
            lwsJustificaciones = new ListView();
            gbEmpleado = new GroupBox();
            lblTipoJustificacion = new Label();
            gbEstado = new GroupBox();
            cmdRechazar = new Button();
            cmdAprobar = new Button();
            label11 = new Label();
            rdHoraExtra = new RadioButton();
            rdPermiso = new RadioButton();
            txtCodigoJustificacion = new TextBox();
            txtNombre = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            txtHoras = new TextBox();
            CalendarDias = new MonthCalendar();
            label10 = new Label();
            dtpFin = new DateTimePicker();
            label6 = new Label();
            dtpInicio = new DateTimePicker();
            btnBuscarEmpleado = new Button();
            btnGuardarJust = new Button();
            TxtIdEmpleado = new TextBox();
            groupBox2 = new GroupBox();
            txtEmpleadoFiltro = new TextBox();
            label1 = new Label();
            btnBuscarEmpleados = new Button();
            txtCodigoEmpleadoFiltro = new TextBox();
            btnFiltroBuscar = new Button();
            ChkPendientes = new CheckBox();
            dtpFechaFinal = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            dtpFechaInicial = new DateTimePicker();
            btnAprobarMasivo = new Button();
            btnRechazarMasivo = new Button();
            btnExportar = new Button();
            gbEmpleado.SuspendLayout();
            gbEstado.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 32);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 29;
            label4.Text = "Inicio:";
            // 
            // cboTipoJustificaciones
            // 
            cboTipoJustificaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoJustificaciones.FormattingEnabled = true;
            cboTipoJustificaciones.ItemHeight = 20;
            cboTipoJustificaciones.Location = new Point(17, 316);
            cboTipoJustificaciones.Margin = new Padding(3, 4, 3, 4);
            cboTipoJustificaciones.Name = "cboTipoJustificaciones";
            cboTipoJustificaciones.Size = new Size(361, 28);
            cboTipoJustificaciones.TabIndex = 6;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Location = new Point(17, 191);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(108, 20);
            lblObservaciones.TabIndex = 25;
            lblObservaciones.Text = "Observaciones:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 36);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 27;
            label3.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 292);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 26;
            label2.Text = "Tipo Justificacion:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(17, 215);
            txtObservaciones.Margin = new Padding(3, 4, 3, 4);
            txtObservaciones.MaxLength = 50;
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(438, 63);
            txtObservaciones.TabIndex = 5;
            // 
            // btnNuevo
            // 
            btnNuevo.Image = Properties.Resources.icons8_add_48;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(528, 19);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Padding = new Padding(0, 0, 11, 0);
            btnNuevo.Size = new Size(126, 32);
            btnNuevo.TabIndex = 1;
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
            btnCerrar.Location = new Point(1592, 680);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(0, 0, 11, 0);
            btnCerrar.Size = new Size(120, 33);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lwsJustificaciones
            // 
            lwsJustificaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lwsJustificaciones.CheckBoxes = true;
            lwsJustificaciones.FullRowSelect = true;
            lwsJustificaciones.GridLines = true;
            lwsJustificaciones.Location = new Point(528, 144);
            lwsJustificaciones.Margin = new Padding(3, 4, 3, 4);
            lwsJustificaciones.MultiSelect = false;
            lwsJustificaciones.Name = "lwsJustificaciones";
            lwsJustificaciones.Size = new Size(1184, 528);
            lwsJustificaciones.TabIndex = 4;
            lwsJustificaciones.UseCompatibleStateImageBehavior = false;
            lwsJustificaciones.View = View.Details;
            lwsJustificaciones.ItemChecked += lwsJustificaciones_ItemChecked;
            lwsJustificaciones.DoubleClick += LwsJustificaciones_DoubleClick;
            // 
            // gbEmpleado
            // 
            gbEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gbEmpleado.Controls.Add(lblTipoJustificacion);
            gbEmpleado.Controls.Add(gbEstado);
            gbEmpleado.Controls.Add(label11);
            gbEmpleado.Controls.Add(rdHoraExtra);
            gbEmpleado.Controls.Add(rdPermiso);
            gbEmpleado.Controls.Add(txtCodigoJustificacion);
            gbEmpleado.Controls.Add(txtNombre);
            gbEmpleado.Controls.Add(label9);
            gbEmpleado.Controls.Add(groupBox1);
            gbEmpleado.Controls.Add(btnBuscarEmpleado);
            gbEmpleado.Controls.Add(btnGuardarJust);
            gbEmpleado.Controls.Add(cboTipoJustificaciones);
            gbEmpleado.Controls.Add(txtObservaciones);
            gbEmpleado.Controls.Add(label2);
            gbEmpleado.Controls.Add(label3);
            gbEmpleado.Controls.Add(lblObservaciones);
            gbEmpleado.Controls.Add(TxtIdEmpleado);
            gbEmpleado.Location = new Point(22, 13);
            gbEmpleado.Margin = new Padding(3, 4, 3, 4);
            gbEmpleado.Name = "gbEmpleado";
            gbEmpleado.Padding = new Padding(3, 4, 10, 4);
            gbEmpleado.Size = new Size(483, 700);
            gbEmpleado.TabIndex = 0;
            gbEmpleado.TabStop = false;
            gbEmpleado.Text = "Justificacion Empleado";
            // 
            // lblTipoJustificacion
            // 
            lblTipoJustificacion.BackColor = Color.OliveDrab;
            lblTipoJustificacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoJustificacion.ForeColor = SystemColors.ControlLightLight;
            lblTipoJustificacion.Location = new Point(28, 102);
            lblTipoJustificacion.Name = "lblTipoJustificacion";
            lblTipoJustificacion.Size = new Size(419, 21);
            lblTipoJustificacion.TabIndex = 53;
            lblTipoJustificacion.Text = "Justificacion de Ausencia";
            lblTipoJustificacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbEstado
            // 
            gbEstado.Controls.Add(cmdRechazar);
            gbEstado.Controls.Add(cmdAprobar);
            gbEstado.Location = new Point(21, 619);
            gbEstado.Name = "gbEstado";
            gbEstado.Size = new Size(285, 73);
            gbEstado.TabIndex = 52;
            gbEstado.TabStop = false;
            gbEstado.Text = "Estado de la Justificacion";
            // 
            // cmdRechazar
            // 
            cmdRechazar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmdRechazar.Image = Properties.Resources.icons8_close_48;
            cmdRechazar.ImageAlign = ContentAlignment.MiddleLeft;
            cmdRechazar.Location = new Point(10, 27);
            cmdRechazar.Margin = new Padding(3, 4, 3, 4);
            cmdRechazar.Name = "cmdRechazar";
            cmdRechazar.Padding = new Padding(0, 0, 11, 0);
            cmdRechazar.Size = new Size(130, 36);
            cmdRechazar.TabIndex = 0;
            cmdRechazar.Text = "Rechazar";
            cmdRechazar.TextAlign = ContentAlignment.MiddleRight;
            cmdRechazar.UseVisualStyleBackColor = true;
            cmdRechazar.Click += cmdRechazar_Click;
            // 
            // cmdAprobar
            // 
            cmdAprobar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmdAprobar.Image = Properties.Resources.icons8_checked_identification_documents_96;
            cmdAprobar.ImageAlign = ContentAlignment.MiddleLeft;
            cmdAprobar.Location = new Point(146, 27);
            cmdAprobar.Margin = new Padding(3, 4, 3, 4);
            cmdAprobar.Name = "cmdAprobar";
            cmdAprobar.Padding = new Padding(0, 0, 11, 0);
            cmdAprobar.Size = new Size(130, 36);
            cmdAprobar.TabIndex = 1;
            cmdAprobar.Text = "Aprobar";
            cmdAprobar.TextAlign = ContentAlignment.MiddleRight;
            cmdAprobar.UseVisualStyleBackColor = true;
            cmdAprobar.Click += cmdAprobar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(254, 24);
            label11.Name = "label11";
            label11.Size = new Size(144, 20);
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
            rdHoraExtra.Location = new Point(340, 48);
            rdHoraExtra.Name = "rdHoraExtra";
            rdHoraExtra.Size = new Size(113, 45);
            rdHoraExtra.TabIndex = 2;
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
            rdPermiso.Location = new Point(205, 48);
            rdPermiso.Name = "rdPermiso";
            rdPermiso.Size = new Size(117, 45);
            rdPermiso.TabIndex = 1;
            rdPermiso.Text = "Permiso";
            rdPermiso.TextAlign = ContentAlignment.MiddleCenter;
            rdPermiso.UseVisualStyleBackColor = true;
            rdPermiso.CheckedChanged += RdPermiso_CheckedChanged;
            // 
            // txtCodigoJustificacion
            // 
            txtCodigoJustificacion.BackColor = SystemColors.Info;
            txtCodigoJustificacion.Enabled = false;
            txtCodigoJustificacion.Location = new Point(48, 33);
            txtCodigoJustificacion.Margin = new Padding(3, 4, 3, 4);
            txtCodigoJustificacion.Name = "txtCodigoJustificacion";
            txtCodigoJustificacion.Size = new Size(73, 27);
            txtCodigoJustificacion.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Info;
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(109, 155);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(275, 27);
            txtNombre.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 131);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 45;
            label9.Text = "Empleado";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHoras);
            groupBox1.Controls.Add(CalendarDias);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtpFin);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpInicio);
            groupBox1.Location = new Point(17, 351);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 257);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Periodo";
            // 
            // txtHoras
            // 
            txtHoras.BackColor = SystemColors.Info;
            txtHoras.Location = new Point(319, 209);
            txtHoras.Margin = new Padding(3, 4, 3, 4);
            txtHoras.MaxLength = 50;
            txtHoras.Multiline = true;
            txtHoras.Name = "txtHoras";
            txtHoras.ReadOnly = true;
            txtHoras.Size = new Size(82, 31);
            txtHoras.TabIndex = 3;
            // 
            // CalendarDias
            // 
            CalendarDias.Location = new Point(11, 32);
            CalendarDias.Name = "CalendarDias";
            CalendarDias.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(319, 168);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 48;
            label10.Text = "Horas:";
            // 
            // dtpFin
            // 
            dtpFin.Checked = false;
            dtpFin.CustomFormat = "hh:mm:ss";
            dtpFin.Format = DateTimePickerFormat.Time;
            dtpFin.Location = new Point(319, 128);
            dtpFin.Name = "dtpFin";
            dtpFin.RightToLeft = RightToLeft.Yes;
            dtpFin.ShowUpDown = true;
            dtpFin.Size = new Size(111, 27);
            dtpFin.TabIndex = 2;
            dtpFin.Value = new DateTime(2024, 8, 16, 23, 28, 0, 0);
            dtpFin.ValueChanged += dtpFin_ValueChanged;
            dtpFin.KeyPress += dtpFin_KeyPress;
            dtpFin.KeyUp += dtpFin_KeyUp;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 105);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 40;
            label6.Text = "Finaliza:";
            // 
            // dtpInicio
            // 
            dtpInicio.Checked = false;
            dtpInicio.CustomFormat = "hh:mm:ss";
            dtpInicio.Format = DateTimePickerFormat.Time;
            dtpInicio.Location = new Point(319, 59);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.ShowUpDown = true;
            dtpInicio.Size = new Size(115, 27);
            dtpInicio.TabIndex = 1;
            dtpInicio.ValueChanged += dtpInicio_ValueChanged;
            dtpInicio.KeyPress += dtpInicio_KeyPress;
            dtpInicio.KeyUp += dtpInicio_KeyUp;
            // 
            // btnBuscarEmpleado
            // 
            btnBuscarEmpleado.Location = new Point(390, 153);
            btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            btnBuscarEmpleado.Size = new Size(39, 29);
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
            btnGuardarJust.Location = new Point(314, 655);
            btnGuardarJust.Margin = new Padding(3, 4, 3, 4);
            btnGuardarJust.Name = "btnGuardarJust";
            btnGuardarJust.Padding = new Padding(0, 0, 11, 0);
            btnGuardarJust.Size = new Size(141, 36);
            btnGuardarJust.TabIndex = 7;
            btnGuardarJust.Text = "Guardar";
            btnGuardarJust.TextAlign = ContentAlignment.MiddleRight;
            btnGuardarJust.UseVisualStyleBackColor = true;
            btnGuardarJust.Click += BtnGuardar_Click;
            // 
            // TxtIdEmpleado
            // 
            TxtIdEmpleado.BackColor = SystemColors.Info;
            TxtIdEmpleado.Enabled = false;
            TxtIdEmpleado.Location = new Point(22, 155);
            TxtIdEmpleado.Margin = new Padding(3, 4, 3, 4);
            TxtIdEmpleado.Name = "TxtIdEmpleado";
            TxtIdEmpleado.Size = new Size(73, 27);
            TxtIdEmpleado.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEmpleadoFiltro);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnBuscarEmpleados);
            groupBox2.Controls.Add(txtCodigoEmpleadoFiltro);
            groupBox2.Controls.Add(btnFiltroBuscar);
            groupBox2.Controls.Add(ChkPendientes);
            groupBox2.Controls.Add(dtpFechaFinal);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dtpFechaInicial);
            groupBox2.Location = new Point(528, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1123, 69);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "Periodo";
            // 
            // txtEmpleadoFiltro
            // 
            txtEmpleadoFiltro.BackColor = SystemColors.Info;
            txtEmpleadoFiltro.Enabled = false;
            txtEmpleadoFiltro.Location = new Point(564, 29);
            txtEmpleadoFiltro.Margin = new Padding(3, 4, 3, 4);
            txtEmpleadoFiltro.Name = "txtEmpleadoFiltro";
            txtEmpleadoFiltro.Size = new Size(275, 27);
            txtEmpleadoFiltro.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(425, 34);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 49;
            label1.Text = "Empl.";
            // 
            // btnBuscarEmpleados
            // 
            btnBuscarEmpleados.Location = new Point(845, 27);
            btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            btnBuscarEmpleados.Size = new Size(39, 29);
            btnBuscarEmpleados.TabIndex = 4;
            btnBuscarEmpleados.Text = "...";
            btnBuscarEmpleados.UseVisualStyleBackColor = true;
            btnBuscarEmpleados.Click += btnBuscarEmpleados_Click;
            // 
            // txtCodigoEmpleadoFiltro
            // 
            txtCodigoEmpleadoFiltro.BackColor = SystemColors.Info;
            txtCodigoEmpleadoFiltro.Enabled = false;
            txtCodigoEmpleadoFiltro.Location = new Point(477, 29);
            txtCodigoEmpleadoFiltro.Margin = new Padding(3, 4, 3, 4);
            txtCodigoEmpleadoFiltro.Name = "txtCodigoEmpleadoFiltro";
            txtCodigoEmpleadoFiltro.Size = new Size(73, 27);
            txtCodigoEmpleadoFiltro.TabIndex = 2;
            // 
            // btnFiltroBuscar
            // 
            btnFiltroBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltroBuscar.Image = Properties.Resources.search2_more_48;
            btnFiltroBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltroBuscar.Location = new Point(1014, 21);
            btnFiltroBuscar.Margin = new Padding(3, 4, 3, 4);
            btnFiltroBuscar.Name = "btnFiltroBuscar";
            btnFiltroBuscar.Padding = new Padding(0, 0, 11, 0);
            btnFiltroBuscar.Size = new Size(93, 40);
            btnFiltroBuscar.TabIndex = 6;
            btnFiltroBuscar.Text = "Buscar";
            btnFiltroBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnFiltroBuscar.UseVisualStyleBackColor = true;
            btnFiltroBuscar.Click += button2_Click;
            // 
            // ChkPendientes
            // 
            ChkPendientes.AutoSize = true;
            ChkPendientes.Location = new Point(912, 30);
            ChkPendientes.Name = "ChkPendientes";
            ChkPendientes.Size = new Size(96, 24);
            ChkPendientes.TabIndex = 5;
            ChkPendientes.Text = "Pendiente";
            ChkPendientes.UseVisualStyleBackColor = true;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.CustomFormat = "yyyy/MM/dd ";
            dtpFechaFinal.Format = DateTimePickerFormat.Custom;
            dtpFechaFinal.Location = new Point(279, 30);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(130, 27);
            dtpFechaFinal.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(211, 32);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 40;
            label7.Text = "Finaliza:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 32);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 29;
            label8.Text = "Inicio:";
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.CustomFormat = "yyyy/MM/dd";
            dtpFechaInicial.Format = DateTimePickerFormat.Custom;
            dtpFechaInicial.Location = new Point(73, 29);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(132, 27);
            dtpFechaInicial.TabIndex = 0;
            // 
            // btnAprobarMasivo
            // 
            btnAprobarMasivo.Image = Properties.Resources.icons8_checked_identification_documents_96;
            btnAprobarMasivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnAprobarMasivo.Location = new Point(660, 19);
            btnAprobarMasivo.Margin = new Padding(3, 4, 3, 4);
            btnAprobarMasivo.Name = "btnAprobarMasivo";
            btnAprobarMasivo.Padding = new Padding(0, 0, 11, 0);
            btnAprobarMasivo.Size = new Size(216, 32);
            btnAprobarMasivo.TabIndex = 2;
            btnAprobarMasivo.Text = "Aprobar Seleccionadas";
            btnAprobarMasivo.TextAlign = ContentAlignment.MiddleRight;
            btnAprobarMasivo.UseVisualStyleBackColor = true;
            btnAprobarMasivo.Click += btnAprobarMasivo_Click;
            // 
            // btnRechazarMasivo
            // 
            btnRechazarMasivo.Image = Properties.Resources.icons8_close_48;
            btnRechazarMasivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnRechazarMasivo.Location = new Point(882, 19);
            btnRechazarMasivo.Margin = new Padding(3, 4, 3, 4);
            btnRechazarMasivo.Name = "btnRechazarMasivo";
            btnRechazarMasivo.Padding = new Padding(0, 0, 11, 0);
            btnRechazarMasivo.Size = new Size(210, 32);
            btnRechazarMasivo.TabIndex = 3;
            btnRechazarMasivo.Text = "Rechazar Seleccionadas";
            btnRechazarMasivo.TextAlign = ContentAlignment.MiddleRight;
            btnRechazarMasivo.UseVisualStyleBackColor = true;
            btnRechazarMasivo.Click += button1_Click;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExportar.Image = Properties.Resources.excel_48;
            btnExportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportar.Location = new Point(528, 680);
            btnExportar.Margin = new Padding(3, 4, 3, 4);
            btnExportar.Name = "btnExportar";
            btnExportar.Padding = new Padding(0, 0, 11, 0);
            btnExportar.Size = new Size(207, 36);
            btnExportar.TabIndex = 5;
            btnExportar.Text = "Copiar en Portapapeles";
            btnExportar.TextAlign = ContentAlignment.MiddleRight;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // FrmJustificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1739, 726);
            Controls.Add(btnExportar);
            Controls.Add(btnRechazarMasivo);
            Controls.Add(btnAprobarMasivo);
            Controls.Add(groupBox2);
            Controls.Add(gbEmpleado);
            Controls.Add(btnNuevo);
            Controls.Add(btnCerrar);
            Controls.Add(lwsJustificaciones);
            Name = "FrmJustificaciones";
            Text = "Justificaciones empleados";
            Load += FrmJustificaciones_Load;
            gbEmpleado.ResumeLayout(false);
            gbEmpleado.PerformLayout();
            gbEstado.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private ComboBox cboTipoJustificaciones;
        private Label lblObservaciones;
        private Label label3;
        private Label label2;
        private TextBox txtObservaciones;
        private TextBox txtEmpleadoFiltro;
        private Label lblTipoJustificacion;
        private Button btnBuscar;
        private Button btnNuevo;
        private Button btnCerrar;
        private ListView lwsJustificaciones;
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
        private TextBox txtHoras;
        private Label label10;
        private MonthCalendar CalendarDias;
        private TextBox txtCodigoEmpleadoFiltro;
        private RadioButton rdPermiso;
        private RadioButton rdHoraExtra;
        private Label label11;
        private TextBox txtCodigoJustificacion;
        private GroupBox gbEstado;
        private Button cmdRechazar;
        private Button cmdAprobar;
        private TextBox TxtIdEmpleado;
        private Label label1;
        private Button btnBuscarEmpleados;
        private Button btnAprobarMasivo;
        private Button button1;
        private Button btnRechazarMasivo;
        private Button btnExportar;
    }
}