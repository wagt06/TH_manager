using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Cto
{
    [Keyless]
    [NotMapped]
    public class CtoJustificacion
    {
        public int CodigoJustificacion { get; set; }
        public int CodigoEmpleado { get; set; }

        public string NombreEmpleado { get; set; }
        public string Observaciones { get; set; }

        public int CodigoTipoJustificacion { get; set; }
        public string TipoJustificacion { get; set; }
        public int CodigoEstado { get; set; }
        public string Estado { get; set; }

        public bool IsPermiso { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public int Horas{ get; set; }

    }
}
