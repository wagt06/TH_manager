using MD.Cto;
using MD.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class MdDbContext:DbContext
    {
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Sucursal> Sucursales { get; set; }
        public virtual DbSet<Marcacion> Marcaciones { get; set; }

        public virtual DbSet<Justificacion> Justificaciones { get; set; }
        public virtual DbSet<TipoJustificacion> TiposJustificaciones { get; set; }
        public virtual DbSet<Horario> Horarios { get; set; }



        /*SP REPORTES*/
        public virtual DbSet<CtoMarcacionesReporte> CtoMarcacionesReporte { get; set; }

        public virtual DbSet<CtoJustificacion> CtoJustificaciones { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // for the other conventions, we do a metadata model loop
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (modelBuilder == null)
                    throw new ArgumentNullException("modelBuilder");

                // equivalent of modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                entityType.SetTableName(entityType.DisplayName());

                // equivalent of modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }

            modelBuilder.Entity<Empleado>()
           .HasOne<Sucursal>(s => s.Sucursal)
           .WithMany(e =>e.Empleados)
           .HasForeignKey(s => s.CodigoSucursal);

            modelBuilder.Entity<Marcacion>()
                 .HasOne<Sucursal>(s => s.Sucursal)
                 .WithMany(e => e.Marcaciones)
                 .HasForeignKey(s => s.CodigoSucursal);


            modelBuilder.Entity<Marcacion>()
              .HasOne<Empleado>(s => s.Empleado)
              .WithMany(e => e.Marcaciones)
              .HasForeignKey(s => s.CodigoEmpleado);

            modelBuilder.Entity<Justificacion>()
             .HasOne<Empleado>(s => s.Empleado)
             .WithMany(e => e.Justificaciones)
             .HasForeignKey(s => s.CodigoEmpleado);

            modelBuilder.Entity<Justificacion>()
           .HasOne<TipoJustificacion>(s => s.TipoJustificacion)
           .WithMany(e => e.Justificaciones)
           .HasForeignKey(s => s.CodigoTipoJustificacion);

            modelBuilder.Entity<Empleado>()
              .HasOne<Horario>(s => s.Horario)
              .WithMany(e => e.Empleados)
              .HasForeignKey(s => s.CodigoHorario);


            base.OnModelCreating(modelBuilder);

            new DbInitializer(modelBuilder).Seed();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Marcaciones;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            optionsBuilder.UseSqlServer(@"Data Source=DELL\SOFIAMSSQ;Initial Catalog=TM-Manager;User Id=Sa;Password=1027061986 ;TrustServerCertificate=true;MultipleActiveResultSets=true");

            //optionsBuilder.UseSqlServer(@"Server=.\\SQLExpress;AttachDbFilename=|DataDirectory|mydbfile.mdf;Database=DbMarcaciones;Trusted_Connection=Yes;");

            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer(@"Server=DVT-CHANGEMENOW\SQLEXPRESS;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;");
        }

    }

    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<TipoJustificacion>().HasData(
                   new TipoJustificacion() { CodigoTipoJustificacion = 1, Descripcion = "Dia Vacaciones", IsActiva = true, IsSalida = false, IsFeriado = false },
                   new TipoJustificacion() { CodigoTipoJustificacion = 2, Descripcion = "Horas Libre", IsActiva = true, IsSalida = false, IsFeriado = false },
                   new TipoJustificacion() { CodigoTipoJustificacion = 3, Descripcion = "Dia Feriado", IsActiva = true, IsSalida = false, IsFeriado = true },
                   new TipoJustificacion() { CodigoTipoJustificacion = 4, Descripcion = "Horas Extras", IsActiva = true, IsSalida = true, IsFeriado = false }
            );

            modelBuilder.Entity<Sucursal>().HasData(
                new Sucursal() { CodigoSucursal = 1,Nombre = "Linda Vista", IsActivo = true, CodigoUsuarioCreacion = 1, FechaCreacion = DateTime.Now, IsEliminado = false },
                new Sucursal() { CodigoSucursal = 2,Nombre = "Metrocentro", IsActivo = true, CodigoUsuarioCreacion = 1, FechaCreacion = DateTime.Now, IsEliminado = false }
            );

            modelBuilder.Entity<Horario>().HasData(
               new Horario() { CodigoHorario = 1,Descripcion = "Manana", Inicia = new DateTime().AddHours(8), Termina = new DateTime().AddHours(17), IsActivo = true },
               new Horario() { CodigoHorario = 2, Descripcion = "Tarde", Inicia = new DateTime().AddHours(12), Termina = new DateTime().AddHours(19), IsActivo = true }
           );

            modelBuilder.Entity<Empleado>().HasData(
             new Empleado() { CodigoEmpleado = 1,NombreEmpleado = "William Gonzalez", Cedula = "0011810860021C", CodigoHorario = 1,CodigoSucursal =  1
             ,Usuario = "wagt06", Contraseña = "123", IsActivo = true,IsEliminado = false,CodigoUsuarioCreacion =1, FechaCreacion= DateTime.Now,IsUsuario = true },

              new Empleado() {
                  CodigoEmpleado = 2,NombreEmpleado = "Bayardo Gonzalez", Cedula = "0011810860021C", CodigoHorario = 1, CodigoSucursal = 1,
                  Usuario = "bagt06", Contraseña = "123", IsActivo = true, IsEliminado = false, CodigoUsuarioCreacion = 1, FechaCreacion = DateTime.Now, IsUsuario = false}
         );

        }
    }


}

