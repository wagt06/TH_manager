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
        private MdDbContext db = new MdDbContext();

        public Empleado BuscarEmpleadoPorCodigo(int codigo ) {
            return db.Empleados.FirstOrDefault(x => x.CodigoEmpleado == codigo);
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
                                    IsUsuario = e.IsUsuario,
                                    Usuario = e.Usuario,
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
                                            IsUsuario = e.IsUsuario,
                                            Usuario = e.Usuario,
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
