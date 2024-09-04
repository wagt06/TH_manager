using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Entidades
{
    public class BaseEntidad
    {
     
        public bool? IsEliminado { get; set; }
        public int CodigoUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int? CodigoUsuarioMod{ get; set; }
        public DateTime? FechaMod { get; set; }
        public int? CodigoUsuarioElimina {get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
