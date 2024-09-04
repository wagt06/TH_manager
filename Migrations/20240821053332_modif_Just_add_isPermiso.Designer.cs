﻿// <auto-generated />
using System;
using MD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MD.Migrations
{
    [DbContext(typeof(MdDbContext))]
    [Migration("20240821053332_modif_Just_add_isPermiso")]
    partial class modif_Just_add_isPermiso
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MD.Entidades.Empleado", b =>
                {
                    b.Property<int>("CodigoEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoEmpleado"));

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CodigoSucursal")
                        .HasColumnType("int");

                    b.Property<int>("CodigoUsuarioCreacion")
                        .HasColumnType("int");

                    b.Property<int?>("CodigoUsuarioElimina")
                        .HasColumnType("int");

                    b.Property<int?>("CodigoUsuarioMod")
                        .HasColumnType("int");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaMod")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActivo")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsEliminado")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUsuario")
                        .HasColumnType("bit");

                    b.Property<string>("NombreEmpleado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CodigoEmpleado");

                    b.HasIndex("CodigoSucursal");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("MD.Entidades.Justificacion", b =>
                {
                    b.Property<int>("CodigoJustificacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoJustificacion"));

                    b.Property<int>("CodigoEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("CodigoEstado")
                        .HasColumnType("int");

                    b.Property<int>("CodigoTipoJustificacion")
                        .HasColumnType("int");

                    b.Property<int>("CodigoUsuarioCreacion")
                        .HasColumnType("int");

                    b.Property<int?>("CodigoUsuarioElimina")
                        .HasColumnType("int");

                    b.Property<int?>("CodigoUsuarioMod")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaMod")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraInicial")
                        .HasColumnType("datetime2");

                    b.Property<int>("Horas")
                        .HasColumnType("int");

                    b.Property<bool?>("IsEliminado")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeriado")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPermiso")
                        .HasColumnType("bit");

                    b.Property<string>("Observacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodigoJustificacion");

                    b.HasIndex("CodigoEmpleado");

                    b.HasIndex("CodigoTipoJustificacion");

                    b.ToTable("Justificacion");
                });

            modelBuilder.Entity("MD.Entidades.Marcacion", b =>
                {
                    b.Property<int>("IdMarcacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMarcacion"));

                    b.Property<int>("CodigoEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("CodigoSucursal")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("IdMarcacion");

                    b.HasIndex("CodigoEmpleado");

                    b.HasIndex("CodigoSucursal");

                    b.ToTable("Marcacion");
                });

            modelBuilder.Entity("MD.Entidades.Sucursal", b =>
                {
                    b.Property<int>("CodigoSucursal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoSucursal"));

                    b.Property<int>("CodigoUsuarioCreacion")
                        .HasColumnType("int");

                    b.Property<int?>("CodigoUsuarioElimina")
                        .HasColumnType("int");

                    b.Property<int?>("CodigoUsuarioMod")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaMod")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActivo")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsEliminado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CodigoSucursal");

                    b.ToTable("Sucursal");
                });

            modelBuilder.Entity("MD.Entidades.TipoJustificacion", b =>
                {
                    b.Property<int>("CodigoTipoJustificacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoTipoJustificacion"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActiva")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeriado")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTiempoExtra")
                        .HasColumnType("bit");

                    b.HasKey("CodigoTipoJustificacion");

                    b.ToTable("TipoJustificacion");
                });

            modelBuilder.Entity("MD.Entidades.Empleado", b =>
                {
                    b.HasOne("MD.Entidades.Sucursal", "Sucursal")
                        .WithMany("Empleados")
                        .HasForeignKey("CodigoSucursal")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("MD.Entidades.Justificacion", b =>
                {
                    b.HasOne("MD.Entidades.Empleado", "Empleado")
                        .WithMany("Justificaciones")
                        .HasForeignKey("CodigoEmpleado")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MD.Entidades.TipoJustificacion", "TipoJustificacion")
                        .WithMany("Justificaciones")
                        .HasForeignKey("CodigoTipoJustificacion")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empleado");

                    b.Navigation("TipoJustificacion");
                });

            modelBuilder.Entity("MD.Entidades.Marcacion", b =>
                {
                    b.HasOne("MD.Entidades.Empleado", "Empleado")
                        .WithMany("Marcaciones")
                        .HasForeignKey("CodigoEmpleado")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MD.Entidades.Sucursal", "Sucursal")
                        .WithMany("Marcaciones")
                        .HasForeignKey("CodigoSucursal")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empleado");

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("MD.Entidades.Empleado", b =>
                {
                    b.Navigation("Justificaciones");

                    b.Navigation("Marcaciones");
                });

            modelBuilder.Entity("MD.Entidades.Sucursal", b =>
                {
                    b.Navigation("Empleados");

                    b.Navigation("Marcaciones");
                });

            modelBuilder.Entity("MD.Entidades.TipoJustificacion", b =>
                {
                    b.Navigation("Justificaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
