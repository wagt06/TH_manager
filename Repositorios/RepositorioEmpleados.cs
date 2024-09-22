using MD.Cto;
using MD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Repositorios
{
    public class RepositorioEmpleados
    {
        private DbContext db = new DbContext();

        public Empleado BuscarEmpleadoPorCodigo(int codigo ) {
            return db.Empleados.FirstOrDefault(x => x.CodigoEmpleado == codigo);
        }

        public Empleado GuardarEmpleado(Empleado empleado) {

            try
            {

                using (DbContext db = new DbContext())
                {
                    Empleado existeEmpleado = db.Empleados.Where(x=>x.CodigoEmpleado == empleado.CodigoEmpleado).FirstOrDefault();

                    if (existeEmpleado == null)
                    {

                        existeEmpleado = db.Empleados.Where(x => x.Cedula == empleado.Cedula).FirstOrDefault();
                        if (existeEmpleado != null)
                            throw new Exception("No se puede agregar el empleado: " + empleado.NombreEmpleado + Environment.NewLine  + "Ya existe un empleado con ese numero de cedula" );

                        if (empleado.CodigoEmpleado == 0) {
                            int codigoEmpleado = db.Empleados.Count() + 1;
                            empleado.CodigoEmpleado = codigoEmpleado;
                        }

                        empleado.CodigoUsuarioCreacion = 1;
                        empleado.FechaCreacion = DateTime.Now;
                        db.Empleados.Add(empleado);
                    }
                    else
                    {
                        empleado.CodigoUsuarioMod = 1;
                        empleado.FechaMod = DateTime.Now;
                        db.Empleados.Update(empleado);
                    }
                    db.SaveChanges();
                }

            return empleado;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public CtoEmpleados CtoEmpleadosPorCodigo(int codigo)
        {
            try
            {
                CtoEmpleados ctoEmpleados;
                ctoEmpleados = (from e in db.Empleados
                                join s in db.Sucursales on e.CodigoSucursal equals s.CodigoSucursal
                                where e.CodigoEmpleado == codigo
                                select new CtoEmpleados
                                {
                                    Codigo = e.CodigoEmpleado,
                                    Nombre = e.NombreEmpleado,
                                    Cedula = e.Cedula,
                                    CodigoSucursal = e.CodigoSucursal,
                                    Sucursal = s.Nombre,
                                    Activo = e.IsActivo,
                                    Contraseña = e.Contraseña,
                                    CodigoHorario = e.CodigoHorario,
                                }).FirstOrDefault();

                return ctoEmpleados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<CtoEmpleados> ListCtoEmpleados() {
                try
                {
                    IEnumerable<CtoEmpleados> ctoEmpleados;
                    ctoEmpleados = (from e in db.Empleados
                                        join s in db.Sucursales on e.CodigoSucursal equals s.CodigoSucursal
                                        select new CtoEmpleados
                                        {
                                            Codigo = e.CodigoEmpleado,
                                            Nombre = e.NombreEmpleado,
                                            Cedula = e.Cedula,
                                            CodigoSucursal = e.CodigoSucursal,
                                            Sucursal = s.Nombre,
                                            Activo = e.IsActivo,
                                            Contraseña = e.Contraseña,
                                            CodigoHorario = e.CodigoHorario,
                                        }).ToList();

                    return ctoEmpleados;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }
    }

    
}
