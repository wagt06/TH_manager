using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Entidades
{
    public class Horario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoHorario { get; set; }
        public string Descripcion { get; set; }
        public DateTime Inicia { get; set;}
        public DateTime Termina { get; set; }
        public bool IsActivo { get; set; }
        public IEnumerable<Empleado> Empleados { get; set; }

    }
}
