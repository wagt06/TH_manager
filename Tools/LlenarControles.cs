using MD.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Tools
{
   static public class LlenarControles
    {
        public static void LlenarCombo(ComboBox combo, List<Cto.SelectCombo> lista, string title ="") {
            if(title == "")
                lista.Add(new Cto.SelectCombo {Codigo = -1, Descripcion = "-- Seleccionar --" });
            
            combo.ValueMember = "Codigo";
            combo.DisplayMember = "Descripcion";
            combo.DataSource = lista.OrderBy(x => x.Codigo).ToList();
        }
    }
}
