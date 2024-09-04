using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Entidades
{
    public class Sucursal:BaseEntidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoSucursal { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }
        public bool IsActivo { get; set; }
        public IEnumerable<Empleado> Empleados { get; set; }

        public IEnumerable<Marcacion> Marcaciones { get; set; }
    }
}
