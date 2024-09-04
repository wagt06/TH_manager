using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Entidades
{
    public class Marcacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMarcacion { get; set; }
        public DateTime Fecha { get; set; }
        public int CodigoEmpleado { get; set; }
        public Empleado Empleado { get; set; }
        public int CodigoSucursal { get; set; }
        public Sucursal Sucursal { get; set; }

    }
}
