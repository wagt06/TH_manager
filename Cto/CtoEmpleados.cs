using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Cto
{
    public class CtoEmpleados
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public int CodigoSucursal { get; set; }
        public string Sucursal { get; set; }

        public int CodigoHorario { get; set; }
        public bool Activo { get; set; }

        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public bool IsUsuario { get; set; }

    }
}
