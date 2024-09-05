using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Entidades
{
    public class Empleado:BaseEntidad
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int CodigoEmpleado { get; set; }
        public int CodigoSucursal { get; set; }
        public Sucursal Sucursal { get; set; }

        public int CodigoHorario { get; set; }
        public  Horario Horario { get; set; }

        [MaxLength(50)]
        public string NombreEmpleado { get; set; }

        [MaxLength(20)]
        public string Cedula { get; set; }

        [MaxLength(20)]
        public string Usuario { get; set; }

        [MaxLength(20)]
        public string Contraseña { get; set; }

        public bool IsUsuario { get; set; }
        public bool IsActivo { get; set; }

        public IEnumerable<Marcacion> Marcaciones { get; set; }
        public IEnumerable<Justificacion> Justificaciones { get; set; }

    }
}
