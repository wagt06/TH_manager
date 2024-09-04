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

        public int HorasReglamentarias { get; set; }
        public int HorasMarcadas { get; set; }
        public int TiempoEnContra { get; set; }
        public int TiempoAFavor { get; set; }
        public int HorasJustificadas { get; set; }
        public int CantidadHorasFinal { get; set; }


    }
}
