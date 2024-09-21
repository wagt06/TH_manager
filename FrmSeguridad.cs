using MD.Entidades;
using MD.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD
{
    public partial class FrmSeguridad : Form
    {
        RepositorioSeguridad rSeguridad = new RepositorioSeguridad();
        private bool isLoad = false;
        public FrmSeguridad()
        {
            InitializeComponent();
        }

        private void FrmSeguridad_Load(object sender, EventArgs e)
        {
            lvwRoles.Columns.Add("Id", 100);
            lvwRoles.Columns.Add("Nombre", 100);
            lvwRoles.Columns.Add("Activo", 100);
            lvwRoles.View = View.Details;
            lvwRoles.FullRowSelect = true;

            MostrarRoles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNuevoRol frmNuevoRol = new FrmNuevoRol();
            frmNuevoRol.ShowDialog();
            MostrarRoles();
            foreach (TreeNode n in trwMenus.Nodes)
            {
                n.Checked = false;
            }
        }

        private void MostrarRoles()
        {
            isLoad = true;

            List<Rol> roles = new List<Rol>();
            roles = rSeguridad.Roles();

            this.lvwRoles.Items.Clear();
            foreach (Rol role in roles)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = role;
                lvi.Text = role.RolId.ToString();
                lvi.SubItems.Add(role.NombreRol);
                lvi.SubItems.Add(role.IsActivo.ToString());
                lvwRoles.Items.Add(lvi);
            }

            List<Menu> menus = new List<Menu>();
            menus = rSeguridad.Menus();

            trwMenus.ShowLines = true;
            trwMenus.BeforeCheck += TrwMenus_BeforeCheck;
            
            foreach (Menu menu in menus)
            {
                TreeNode n = new TreeNode { Name = menu.MenuId.ToString(), Text = menu.NombreMenu,Tag =  menu,ToolTipText = "Menu" };
                
                foreach (MenusOpciones o in menu.Opciones)
                {
                    n.Nodes.Add(new TreeNode { Name = o.MenuOpcionesId.ToString(), Text = o.NombreOpcion,ToolTipText = "opcion" });
                }
                trwMenus.Nodes.Add(n);
            }
            trwMenus.ExpandAll();

            isLoad = false;

        }

        private void TrwMenus_BeforeCheck(object? sender, TreeViewCancelEventArgs e)
        {
            if (isLoad)
                return;

            if (this.lvwRoles.SelectedItems.Count == 0)
                return;

            if (e.Node.ToolTipText == "Menu")
            {
                Menu m = (Menu)e.Node.Tag;
                RolMenu rm = new RolMenu { MenuId = m.MenuId, RolId = int.Parse(this.lvwRoles.SelectedItems[0].Text),IsActivo = !e.Node.Checked,RolMenuId = 0};
                rSeguridad.MenusAddOrUpdate(rm);
            }
            else {
                MenusOpciones m = (MenusOpciones)e.Node.Tag;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwRoles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            isLoad = true;

            if (this.lvwRoles.SelectedItems.Count == 0)
                return;

            int rollId = int.Parse(this.lvwRoles.SelectedItems[0].Text);

            List<RolMenu> rolMenu = new List<RolMenu>();
            rolMenu = rSeguridad.RollMenuByRolId(rollId);


            foreach (TreeNode n in trwMenus.Nodes)
            {
                n.Checked = false;
            }

            foreach (RolMenu rol in rolMenu)
            {
                TreeNode[] n = trwMenus.Nodes.Find(rol.MenuId.ToString(), false);
                if (n.Count() > 0) {
                    n[0].Checked = true;
                }
            }

            isLoad = false;

        }
    }
}
