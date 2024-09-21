using MD.Cto;
using MD.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD
{
    public partial class FrmSucursal : Form
    {

        List<Sucursal> sucursales;


        public FrmSucursal()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("todos los campos son requeridos");
                return;
            }


            Sucursal sucursal = new Sucursal
            {
                CodigoSucursal = this.TxtId.Text.Length > 0 ? int.Parse(this.TxtId.Text) : 0,
                Nombre = this.txtNombre.Text,
                IsActivo = this.chkActivo.Checked,
            };

            if (this.TxtId.Text.Length > 0)
            {
                sucursal.CodigoUsuarioCreacion = 1;
                sucursal.FechaCreacion = DateTime.Now;
            }
            else
            {
                sucursal.CodigoUsuarioMod = 1;
                sucursal.FechaMod = DateTime.Now;
            }

            using (DbContext db = new DbContext())
            {
                if (sucursal.CodigoSucursal == 0)
                {
                    db.Sucursales.Add(sucursal);
                }
                else
                {
                    db.Sucursales.Update(sucursal);
                }
                db.SaveChanges();
            }
            CargarSucursales();

            Limpiar();
        }


        private void CargarSucursales()
        {
            try
            {
                this.lwsSucursales.Items.Clear();


                using (DbContext db = new DbContext())
                {

                    sucursales = db.Sucursales.ToList();
                }

                foreach (Sucursal s in sucursales)
                {

                    ListViewItem lista = new ListViewItem(s.CodigoSucursal.ToString());
                    lista.SubItems.Add(s.Nombre);
                    lista.SubItems.Add(s.IsActivo.ToString());
                    this.lwsSucursales.Items.Add(lista);

                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmSucursal_Load(object sender, EventArgs e)
        {
            this.lwsSucursales.Columns.Add("Codigo", 100);
            this.lwsSucursales.Columns.Add("Sucursal", 250);
            this.lwsSucursales.Columns.Add("Activo", 250);

            CargarSucursales();
        }

        private void lwsSucursales_Click(object sender, EventArgs e)
        {
            if (this.lwsSucursales.Items.Count > 0)
            {
                if (this.lwsSucursales.SelectedItems[0].Text != "")
                {

                    int codigo = int.Parse(this.lwsSucursales.SelectedItems[0].Text);

                    Sucursal sucursal = sucursales.Where(x => x.CodigoSucursal == codigo).FirstOrDefault();
                    this.TxtId.Text = sucursal.CodigoSucursal.ToString();
                    this.txtNombre.Text = sucursal.Nombre;
                    this.chkActivo.Checked = sucursal.IsActivo;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            this.TxtId.Text = "";
            this.txtNombre.Text = "";
            this.chkActivo.Checked = true;
        }
    }
}
