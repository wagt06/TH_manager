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
    public class DbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Sucursal> Sucursales { get; set; }
        public virtual DbSet<Marcacion> Marcaciones { get; set; }

        public virtual DbSet<Justificacion> Justificaciones { get; set; }
        public virtual DbSet<TipoJustificacion> TiposJustificaciones { get; set; }
        public virtual DbSet<Horario> Horarios { get; set; }

        /*Seguridad*/
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenusOpciones> MenuOpciones { get; set; }

        public virtual DbSet<Rol> Roll { get; set; }
        public virtual DbSet<RolMenu> RollMenus { get; set; }
        public virtual DbSet<RolMenuOpciones> RollMenuOpciones { get; set; }





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

            //Seguridad
            modelBuilder.Entity<Usuario>()
           .HasOne<Rol>(s => s.Roll)
           .WithMany(e => e.Usuarios)
           .HasForeignKey(s => s.UsuarioId);

            modelBuilder.Entity<Rol>()
              .HasMany<RolMenu>(s => s.RolMenus)
              .WithOne(e => e.Rol)
              .HasForeignKey(s => s.RolId);


            modelBuilder.Entity<RolMenu>()
            .HasMany<RolMenuOpciones>(s => s.RolMenuOpciones)
            .WithOne(e => e.RolMenu)
            .HasForeignKey(s => s.RolMenuId);

            modelBuilder.Entity<Menu>()
           .HasMany<MenusOpciones>(s => s.Opciones)
           .WithOne(e => e.Menu)
           .HasForeignKey(s => s.MenuId);


            base.OnModelCreating(modelBuilder);

            new DbInitializer(modelBuilder).Seed();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TM-Manager;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            optionsBuilder.UseSqlServer(@"Data Source=DELL\SOFIAMSSQ;Initial Catalog=TM-Manager;User Id=Sa;Password=1027061986 ;TrustServerCertificate=true;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);

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
                   new TipoJustificacion() { CodigoTipoJustificacion = 1, Descripcion = "Dia Vacaciones", IsActiva = true, IsSalida = true, IsFeriado = false },
                   new TipoJustificacion() { CodigoTipoJustificacion = 2, Descripcion = "Horas Libre", IsActiva = true, IsSalida = true, IsFeriado = false },
                   new TipoJustificacion() { CodigoTipoJustificacion = 3, Descripcion = "Dia Feriado", IsActiva = true, IsSalida = true, IsFeriado = false },
                   new TipoJustificacion() { CodigoTipoJustificacion = 4, Descripcion = "Horas Extras", IsActiva = true, IsSalida = false, IsFeriado = false }
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
             new Empleado()
             {
                 CodigoEmpleado = 1,
                 NombreEmpleado = "Admin",
                 Cedula = "",
                 CodigoHorario = 1,
                 CodigoSucursal = 1
             ,
                 Usuario = "admin",
                 Contraseña = "123",
                 IsActivo = true,
                 IsEliminado = false,
                 CodigoUsuarioCreacion = 1,
                 FechaCreacion = DateTime.Now,
                 IsUsuario = true
             });


            modelBuilder.Entity<Menu>().HasData(
            new Menu() { MenuId = 1, Modulo = "Empleados", NombreMenu = "Empleado" },
            new Menu() { MenuId = 2, Modulo = "Empleados", NombreMenu = "Justificaciones" },
            new Menu() { MenuId = 3, Modulo = "Empleados", NombreMenu = "Reportes" },
            new Menu() { MenuId = 4, Modulo = "Seguridad", NombreMenu = "Roles" }
            );

            modelBuilder.Entity<MenusOpciones>().HasData(
            new MenusOpciones() { MenuId = 2, MenuOpcionesId = 4, NombreOpcion = "Agregar" },
            new MenusOpciones() { MenuId = 2, MenuOpcionesId = 5, NombreOpcion = "Modificar" },
            new MenusOpciones() { MenuId = 2, MenuOpcionesId = 6, NombreOpcion = "Eliminar" },
            new MenusOpciones() { MenuId = 2, MenuOpcionesId = 7, NombreOpcion = "Aprobar" },
            new MenusOpciones() { MenuId = 2, MenuOpcionesId = 8, NombreOpcion = "Rechazar" },
            new MenusOpciones() { MenuId = 1, MenuOpcionesId = 1, NombreOpcion = "Agregar" },
            new MenusOpciones() { MenuId = 1, MenuOpcionesId = 2, NombreOpcion = "Modificar" },
            new MenusOpciones() { MenuId = 1, MenuOpcionesId = 3, NombreOpcion = "Eliminar" }
            );


            modelBuilder.Entity<Rol>().HasData(
                new Rol()
                {
                    IsActivo = true,
                    RolId = 1,
                    NombreRol = "Admin",
                });


            modelBuilder.Entity<RolMenu>().HasData(
             new RolMenu() { MenuId = 1, RolId = 1, IsActivo = true, RolMenuId = 1 },
             new RolMenu() { MenuId = 2, RolId = 1, IsActivo = true, RolMenuId = 2 },
             new RolMenu() { MenuId = 3, RolId = 1, IsActivo = true, RolMenuId = 3 },
             new RolMenu() { MenuId = 4, RolId = 1, IsActivo = true, RolMenuId = 4 }
             );


            modelBuilder.Entity<Usuario>().HasData(
            new Usuario()
            {
                UsuarioId = 1,
                Nombre = "wagt06",
                Contrasena = "123",
                CorreoElectronico = "wagt06@gmail.com",
                IsEliminado = false,
                RollId = 1,
                FechaCreacion = DateTime.Now,
                CodigoUsuarioCreacion = 1
            });


        }
    }


}

