using MD.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Repositorios
{
    public class RepositorioMarcaciones
    {

        public Empleado GuardarMarcacionesPorCedula(string Cedula) {
			try
			{
                using (MdDbContext bd = new MdDbContext())
                {
                    Empleado empleado = bd.Empleados
                                        .Include(x => x.Sucursal)
                                        .Where(x => x.Cedula == Cedula).FirstOrDefault();

                    if (empleado == null)
                        throw new Exception("No Existe el empleado");

                    
                        Marcacion nuevaMarcacion = new Marcacion
                        {
                            CodigoEmpleado = empleado.CodigoEmpleado,
                            Fecha = DateTime.Now,
                            CodigoSucursal = empleado.Sucursal.CodigoSucursal

                        };
                        bd.Marcaciones.Add(nuevaMarcacion);
                        bd.SaveChanges();

                        return empleado;
                    
                };
            }
			catch (Exception)
			{

				throw;
			}
        }

        public int ImportarMarcaciones(List<Marcacion> marcaciones)
        {
            try
            {
                int cantidadGuardadas = 0;
                using (MdDbContext bd = new MdDbContext())
                {
                    foreach (Marcacion m in marcaciones) {
                        Empleado empleado = bd.Empleados
                                            .Include(x => x.Sucursal)
                                            .Where(x => x.CodigoEmpleado == m.CodigoEmpleado).FirstOrDefault();

                        if (empleado == null)
                            throw new Exception("No Existe el empleado");

                        Marcacion marcacionExistente = bd.Marcaciones.Where(x => x.CodigoEmpleado == m.CodigoEmpleado && x.Fecha == m.Fecha).FirstOrDefault();
                        if (marcacionExistente == null)
                        {
                            bd.Marcaciones.Add(m);
                            bd.SaveChanges();
                            cantidadGuardadas += 1;
                        }
                    }
                    
                    return cantidadGuardadas;

                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Marcacion> MarcacionesPorFecha(DateTime FechaInicial, DateTime FechaFinal, int CodigoSucursal) {
            using (MdDbContext db = new MdDbContext()) {
                return db.Marcaciones.Where(x => x.Fecha >= FechaInicial && x.Fecha <= FechaFinal && x.CodigoSucursal == CodigoSucursal).ToList();
            }
        }

    }


}
