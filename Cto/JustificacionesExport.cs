using MD.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Cto
{
    public class JustificacionesExport
    {
        public int CodigoEmpleado { get; set; }
        public string Observacion { get; set; }
        public int CodigoTipoJustificacion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public decimal Horas { get; set; }
        public int CodigoEstado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
