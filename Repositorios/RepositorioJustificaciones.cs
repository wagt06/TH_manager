using MD.Cto;
using MD.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Repositorios
{
    public class RepositorioJustificaciones
    {
        DbContext db = new DbContext();

        public Justificacion JustificacionPorFechaTipo(Justificacion justificacion) {
            try
            {
                Justificacion justificacionExist = db.Justificaciones
                .Where(x => x.Fecha == justificacion.Fecha && x.IsPermiso == justificacion.IsPermiso && x.CodigoEmpleado == justificacion.CodigoEmpleado && (x.CodigoEstado ==2 || x.CodigoEstado == 1) && x.Fecha.Date == justificacion.Fecha.Date)
                .FirstOrDefault();
                return justificacionExist;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Justificacion JustificacionPorId(int codigoJustificacion)
        {
            try
            {
                Justificacion justificacionExist = db.Justificaciones
                .Where(x => x.CodigoJustificacion  == codigoJustificacion)
                .FirstOrDefault();
                return justificacionExist;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Justificacion UpdateEstado(int CodigoJustificacion, int Estado)
        {
            try
            {
                Justificacion justificacion = db.Justificaciones.FirstOrDefault(x => x.CodigoJustificacion == CodigoJustificacion);
                if (justificacion == null)
                    throw new Exception("No existe esta justificacion");
                justificacion.CodigoEstado = Estado;
                db.Justificaciones.Update(justificacion);
                db.SaveChanges();
                return justificacion;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Justificacion GuardarJustificacion(Justificacion justificacion) { 
            try 
            {
                Justificacion justificacionExist;
                if (justificacion.CodigoJustificacion == 0)
                {
                    // justificacionExist = db.Justificaciones
                    //    .Where(x => x.Fecha == justificacion.Fecha)
                    //    .FirstOrDefault();

                    ////Justificacion de salida solo una
                    //if (justificacionExist != null && justificacion.CodigoTipoJustificacion == 1)
                    //{
                    //    throw new Exception($"Ya existe una justificacion para el dia {justificacionExist.Fecha.ToString("yyy/MM/dd")}");
                    //}

                    //validadar si existe una justificacion
                    justificacionExist = db.Justificaciones
                        .Where(x => x.Fecha.Date == justificacion.Fecha.Date
                            && x.HoraInicial.Hour >= justificacion.HoraInicial.Hour && x.HoraInicial.Hour <= justificacion.HoraFinal.Hour
                            && x.HoraFinal.Hour >= justificacion.HoraInicial.Hour && x.HoraInicial.Hour <= justificacion.HoraFinal.Hour
                            && (x.CodigoEstado == 1 || x.CodigoEstado == 2)
                            )
                        .FirstOrDefault();

                    if (justificacionExist != null)
                    {
                        throw new Exception($"Ya existe una justificacion para el dia {justificacionExist.Fecha.ToString("yyy/MM/dd")} de {justificacionExist.HoraInicial.ToString("hh:mm:ss")} a las {justificacionExist.HoraFinal.ToString("hh:mm:ss")}");
                    }

                    db.Add(justificacion);
                }
                else {

                    justificacionExist = db.Justificaciones
                           .Where(x => x.CodigoJustificacion == justificacion.CodigoJustificacion)
                           .FirstOrDefault();
                    justificacionExist.CodigoEstado = justificacion.CodigoEstado;
                    justificacionExist.FechaMod = DateTime.Now;
                    justificacionExist.CodigoUsuarioMod = justificacion.CodigoUsuarioMod;
                }
                db.SaveChanges();
                return justificacion;
            } 
            catch(Exception ex) 
            {
                throw ex;
            }
        }
        public int ImportarJustificacion(List<Justificacion> justificaciones)
        {
            try
            {
                int cantidadImportadas =0;
                foreach (Justificacion just in justificaciones) {
                    Justificacion justificacionExist;

                    Empleado empleado = db.Empleados.Where(x=>x.CodigoEmpleado == just.CodigoEmpleado).FirstOrDefault();
                    if (empleado != null)
                    {
                        if (just.CodigoJustificacion == 0)
                        {
                            justificacionExist = db.Justificaciones
                               .Where(x => x.Fecha == just.Fecha)
                               .FirstOrDefault();

                            //Justificacion de salida solo una
                            if (!(justificacionExist != null && just.CodigoTipoJustificacion == 1))
                            {
                                //validadar si existe una justificacion
                                justificacionExist = db.Justificaciones
                                    .Where(x => x.Fecha == just.Fecha
                                    && x.HoraInicial >= just.HoraInicial && x.HoraInicial <= just.HoraFinal
                                    && x.HoraFinal >= just.HoraInicial && x.HoraInicial <= just.HoraFinal
                                )
                                .FirstOrDefault();
                            }

                            if (justificacionExist == null)
                            {
                                db.Add(just);
                                cantidadImportadas += db.SaveChanges();
                            }
                        }
                    }
                }
                
            
                return cantidadImportadas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<CtoJustificacion> CtoJustificacionLista(FiltroBusqueda filtro)
        {
            try
            {
                List<Justificacion> jusEmpleados = new List<Justificacion>();


                if (!filtro.IsPendiente)
                {
                    jusEmpleados = db.Justificaciones
                                     .Include(x => x.Empleado)
                                     .Include(t => t.TipoJustificacion)
                                     .Where(x => x.Fecha >= filtro.FechaInicial && x.Fecha <= filtro.FechaFinal)
                                     .ToList();

                 
                }
                else
                {
                    jusEmpleados = db.Justificaciones
                                   .Include(x => x.Empleado)
                                   .Include(t => t.TipoJustificacion)
                                   .Where(x => x.CodigoEstado == 1
                                   && x.Fecha >= filtro.FechaInicial && x.Fecha <= filtro.FechaFinal)
                                   .ToList();
                }

                IEnumerable<CtoJustificacion> justificaciones =  (from j in jusEmpleados
                                                                 join t in ListaEstadoJustificaciones() 
                                                                 on j.CodigoEstado equals t.CodigoEstadoJustificacion
                                                                 //where j.CodigoEmpleado == filtro.Codigo
                                                                 select new CtoJustificacion
                                                                 {
                                                                     CodigoJustificacion = j.CodigoJustificacion,
                                                                     CodigoEmpleado = j.CodigoEmpleado,
                                                                     CodigoEstado = j.CodigoEstado,
                                                                     Estado = t.Descripcion,
                                                                     CodigoTipoJustificacion = j.CodigoTipoJustificacion,
                                                                     TipoJustificacion = j.TipoJustificacion.Descripcion,
                                                                     HoraInicio = j.HoraInicial,
                                                                     HoraFin = j.HoraFinal,
                                                                     Fecha = j.Fecha,
                                                                     Horas = j.Horas,
                                                                     NombreEmpleado = j.Empleado.NombreEmpleado,
                                                                     Observaciones = j.Observacion,
                                                                     IsPermiso = j.TipoJustificacion.IsSalida,
                    
                                                                 }).ToList();
                return justificaciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CtoJustificacion CtoJustificacionById(int justificacionId)
        {
            try
            {
   
                List<Justificacion> justificacion = db.Justificaciones
                                   .Include(x => x.Empleado)
                                   .Include(t => t.TipoJustificacion)
                                   .Where(x => x.CodigoJustificacion == justificacionId)
                                   .ToList();
  

                CtoJustificacion justificaciones = (from j in justificacion
                                                    join t in ListaEstadoJustificaciones()
                                                                 on j.CodigoEstado equals t.CodigoEstadoJustificacion
                                                                 select new CtoJustificacion
                                                                 {
                                                                     CodigoJustificacion = j.CodigoJustificacion,
                                                                     CodigoEmpleado = j.CodigoEmpleado,
                                                                     CodigoEstado = j.CodigoEstado,
                                                                     Estado = t.Descripcion,
                                                                     CodigoTipoJustificacion = j.CodigoTipoJustificacion,
                                                                     TipoJustificacion = j.TipoJustificacion.Descripcion,
                                                                     HoraInicio = j.HoraInicial,
                                                                     HoraFin = j.HoraFinal,
                                                                     Fecha = j.Fecha,
                                                                     Horas = j.Horas,
                                                                     NombreEmpleado = j.Empleado.NombreEmpleado,
                                                                     Observaciones = j.Observacion,
                                                                     IsPermiso = j.TipoJustificacion.IsSalida,

                                                                 }).FirstOrDefault();
                return justificaciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Justificacion> JustificacionesPorFecha(DateTime fechaInicial, DateTime FechaFinal, int CodigoSucursal) {

            return db.Justificaciones
                .Include(x=>x.Empleado)
                .Where(x=>x.Fecha >= fechaInicial && x.Fecha<= FechaFinal && x.Empleado.CodigoSucursal == CodigoSucursal).ToList();
        }
        public List<TipoJustificacion> ListaTipoJustificaciones()
        {
            return db.TiposJustificaciones.Where(x=>x.IsActiva).ToList();
        }
        public IEnumerable<Estados> ListaEstadoJustificaciones()
        {
            List<Estados> estados = new List<Estados>();
            estados.Add(new Estados { CodigoEstadoJustificacion = 1, Descripcion = "Pendiente", IsActiva = true });
            estados.Add(new Estados { CodigoEstadoJustificacion = 2, Descripcion = "Aprobado", IsActiva = true });
            estados.Add(new Estados { CodigoEstadoJustificacion = 3, Descripcion = "Rechazado", IsActiva = true });

            return estados;
        }
    }
}
