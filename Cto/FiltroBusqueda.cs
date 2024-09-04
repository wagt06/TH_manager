using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Cto
{
    public class FiltroBusqueda
    {
        public int? Codigo { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public bool IsActivo { get; set; }
        public bool IsPendiente { get; set; }
        public bool IsBorrado { get; set; }

    }
}
