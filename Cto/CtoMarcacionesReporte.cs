using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Cto
{
    [Keyless]
    public class CtoMarcacionesReporte
    {
        public int CodigoEmpleado { get; set; }
        public string NombreEmpleado { get; set; }

        public int CodigoSucursal { get; set; }

        public string Sucursal { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime? Entrada { get; set; }

        public DateTime? Salida { get; set; }

        public decimal HorasReglamentarias { get; set; }
        public decimal HorasMarcadas { get; set; }
        public decimal TiempoEnContra { get; set; }
        public decimal TiempoAFavor { get; set; }
        public decimal HorasJustificadas { get; set; }
        public decimal CantidadHorasFinal { get; set; }
        public decimal HorasExtras { get; set; }


    }
}
