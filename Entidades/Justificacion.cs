using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Entidades
{
    public class Justificacion:BaseEntidad
    {  
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoJustificacion { get; set; }
        public int CodigoEmpleado { get; set; }
        public Empleado Empleado { get; set; }
        public string Observacion { get; set; }
        public int CodigoTipoJustificacion { get; set; }
        public TipoJustificacion TipoJustificacion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraInicial  { get; set; }
        public DateTime HoraFinal { get; set; }
        public int Horas { get; set; }
        public bool IsPermiso { get; set; }
        public bool IsFeriado { get; set; }
        public int CodigoEstado { get; set; }


    }

    public class TipoJustificacion {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoTipoJustificacion { get; set; }
        public string Descripcion { get; set; }
        public bool IsFeriado { get; set; }
        public bool IsSalida { get; set; }
        public bool IsActiva { get; set; }
        public IEnumerable<Justificacion> Justificaciones { get; set; }

    }

    public class Estados
    {
        public int CodigoEstadoJustificacion { get; set; }
        public string Descripcion { get; set; }
        public bool IsActiva { get; set; }
    }


}
