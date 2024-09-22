using MD.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Tools
{
   static public class Tool
    {
        public static void LlenarCombo(ComboBox combo, List<Cto.SelectCombo> lista, string title ="") {
            if(title == "")
                lista.Add(new Cto.SelectCombo {Codigo = -1, Descripcion = "-- Seleccionar --" });
            
            combo.ValueMember = "Codigo";
            combo.DisplayMember = "Descripcion";
            combo.DataSource = lista.OrderBy(x => x.Codigo).ToList();
        }

        public static void CopyListBox(ListView list)
        {
            try
            {
                if(list.Items.Count == 0)
                    return;

                StringBuilder sb = new StringBuilder();
                foreach (ColumnHeader columns in list.Columns)
                {
                    sb.Append(columns.Text + "\t");
                }
                sb.AppendLine();
                foreach (var item in list.Items)
                {


                    ListViewItem l = item as ListViewItem;
                    if (l != null)
                        foreach (ListViewItem.ListViewSubItem sub in l.SubItems)
                            sb.Append(sub.Text + "\t");
                    sb.AppendLine();
                }
                Clipboard.SetDataObject(sb.ToString());
                MessageBox.Show("Se copiaron los datos al portapapeles", "Portapapeles de TH", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
