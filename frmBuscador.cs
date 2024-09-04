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
    public partial class frmBuscador : Form
    {

        public string tipoBusqueda;
        public string codigoBusqueda;
        public frmBuscador()
        {
            InitializeComponent();
        }

        private void frmBuscador_Load(object sender, EventArgs e)
        {
            if (tipoBusqueda == "Empleado")
            {
                this.gbFechas.Visible = false;

                this.lwsDatos.Columns.Clear();
                this.lwsDatos.Columns.Add("Codigo", 100);
                this.lwsDatos.Columns.Add("Nombre", 250);
                this.lwsDatos.Columns.Add("Cedula", 150);
                this.lwsDatos.Columns.Add("Sucursal", 150);
                this.lwsDatos.Columns.Add("Activo", 100);
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (tipoBusqueda == "Empleado")
            {
                CargarEmpleados();

            }
        }

        private void CargarEmpleados()
        {


            IEnumerable<CtoEmpleados> ctoEmpleados;
            this.lwsDatos.Items.Clear();
            using (MdDbContext db = new MdDbContext())
            {

                ctoEmpleados = (from e in db.Empleados
                                .Where(x => x.NombreEmpleado.Contains(txtBusqueda.Text) || x.CodigoEmpleado.ToString() == txtBusqueda.Text)
                                join s in db.Sucursales on e.CodigoSucursal equals s.CodigoSucursal
                                select new CtoEmpleados
                                {
                                    Codigo = e.CodigoEmpleado,
                                    Nombre = e.NombreEmpleado,
                                    Cedula = e.Cedula,
                                    CodigoSucursal = e.CodigoSucursal,
                                    Sucursal = s.Nombre,
                                    Activo = e.IsActivo,
                                    IsUsuario = e.IsUsuario,
                                    Usuario = e.Usuario,
                                    Contraseña = e.Contraseña
                                }).ToList();
            }

            foreach (CtoEmpleados e in ctoEmpleados)
            {

                ListViewItem lista = new ListViewItem(e.Codigo.ToString());
                lista.SubItems.Add(e.Nombre);
                lista.SubItems.Add(e.Cedula);
                lista.SubItems.Add(e.Sucursal);
                lista.SubItems.Add(e.Activo.ToString());

                this.lwsDatos.Items.Add(lista);

            }


        }

        private void lwsDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lwsDatos.Items.Count == 0)
                return;
            if (this.lwsDatos.SelectedItems[0].Text == "")
                return;

            codigoBusqueda = this.lwsDatos.SelectedItems[0].Text;
            this.Close();
        }

        private void lwsDatos_DoubleClick(object sender, EventArgs e)
        {
            if (this.lwsDatos.Items.Count == 0)
                return;
            if (this.lwsDatos.SelectedItems[0].Text == "")
                return;

            codigoBusqueda = this.lwsDatos.SelectedItems[0].Text;
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
