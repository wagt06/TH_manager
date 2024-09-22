namespace MD
{
    partial class FrmSeguridad
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeguridad));
            groupBox1 = new GroupBox();
            lvwRoles = new ListView();
            imageList1 = new ImageList(components);
            groupBox2 = new GroupBox();
            trwMenus = new TreeView();
            btnCerrar = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(lvwRoles);
            groupBox1.Location = new Point(14, 56);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(351, 695);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Roles";
            // 
            // lvwRoles
            // 
            lvwRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lvwRoles.LargeImageList = imageList1;
            lvwRoles.Location = new Point(7, 29);
            lvwRoles.Margin = new Padding(3, 4, 3, 4);
            lvwRoles.Name = "lvwRoles";
            lvwRoles.Size = new Size(333, 656);
            lvwRoles.SmallImageList = imageList1;
            lvwRoles.TabIndex = 0;
            lvwRoles.UseCompatibleStateImageBehavior = false;
            lvwRoles.MouseDoubleClick += lvwRoles_MouseDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth16Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "user.ico");
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(trwMenus);
            groupBox2.Location = new Point(371, 56);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1293, 695);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Permisos del Sistema";
            // 
            // trwMenus
            // 
            trwMenus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trwMenus.BorderStyle = BorderStyle.FixedSingle;
            trwMenus.CheckBoxes = true;
            trwMenus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            trwMenus.FullRowSelect = true;
            trwMenus.ItemHeight = 25;
            trwMenus.Location = new Point(7, 29);
            trwMenus.Margin = new Padding(3, 4, 3, 4);
            trwMenus.Name = "trwMenus";
            trwMenus.Size = new Size(1271, 657);
            trwMenus.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Image = Properties.Resources.icons8_close_48;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(1546, 754);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(0, 0, 11, 0);
            btnCerrar.Size = new Size(120, 53);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.MiddleRight;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Image = Properties.Resources.icons8_add_48;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(245, 759);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 0, 11, 0);
            button1.Size = new Size(120, 48);
            button1.TabIndex = 15;
            button1.Text = "Nuevo Rol";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmSeguridad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1678, 820);
            Controls.Add(button1);
            Controls.Add(btnCerrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSeguridad";
            Text = "Seguridad";
            Load += FrmSeguridad_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lvwRoles;
        private GroupBox groupBox2;
        private TreeView trwMenus;
        private Button btnCerrar;
        private Button button1;
        private ImageList imageList1;
    }
}