using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Tools
{
    public static class CargarArchivoText
    {
        public static string LeerArchivo(string ruta) {
            try
            {
                String linea="";
                String text = "";
                StreamReader sr = new StreamReader(ruta);
                while (linea != null)
                {
                    linea = sr.ReadLine();
                    text += linea;
                }
                sr.Close();
                return text;
            }
            catch (Exception e)
            {
                return "";
            }


        }
    }
}
