using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MD.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CtoMarcacionesReporte",
                columns: table => new
                {
                    CodigoEmpleado = table.Column<int>(type: "int", nullable: false),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoSucursal = table.Column<int>(type: "int", nullable: false),
                    Sucursal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Entrada = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HorasReglamentarias = table.Column<int>(type: "int", nullable: false),
                    HorasMarcadas = table.Column<int>(type: "int", nullable: false),
                    TiempoEnContra = table.Column<int>(type: "int", nullable: false),
                    TiempoAFavor = table.Column<int>(type: "int", nullable: false),
                    HorasJustificadas = table.Column<int>(type: "int", nullable: false),
                    CantidadHorasFinal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Horario",
                columns: table => new
                {
                    CodigoHorario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inicia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Termina = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horario", x => x.CodigoHorario);
                });

            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    CodigoSucursal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActivo = table.Column<bool>(type: "bit", nullable: false),
                    IsEliminado = table.Column<bool>(type: "bit", nullable: true),
                    CodigoUsuarioCreacion = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodigoUsuarioMod = table.Column<int>(type: "int", nullable: true),
                    FechaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodigoUsuarioElimina = table.Column<int>(type: "int", nullable: true),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.CodigoSucursal);
                });

            migrationBuilder.CreateTable(
                name: "TipoJustificacion",
                columns: table => new
                {
                    CodigoTipoJustificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFeriado = table.Column<bool>(type: "bit", nullable: false),
                    IsSalida = table.Column<bool>(type: "bit", nullable: false),
                    IsActiva = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoJustificacion", x => x.CodigoTipoJustificacion);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    CodigoEmpleado = table.Column<int>(type: "int", nullable: false),
                    CodigoSucursal = table.Column<int>(type: "int", nullable: false),
                    CodigoHorario = table.Column<int>(type: "int", nullable: false),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsUsuario = table.Column<bool>(type: "bit", nullable: false),
                    IsActivo = table.Column<bool>(type: "bit", nullable: false),
                    IsEliminado = table.Column<bool>(type: "bit", nullable: true),
                    CodigoUsuarioCreacion = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodigoUsuarioMod = table.Column<int>(type: "int", nullable: true),
                    FechaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodigoUsuarioElimina = table.Column<int>(type: "int", nullable: true),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.CodigoEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleado_Horario_CodigoHorario",
                        column: x => x.CodigoHorario,
                        principalTable: "Horario",
                        principalColumn: "CodigoHorario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empleado_Sucursal_CodigoSucursal",
                        column: x => x.CodigoSucursal,
                        principalTable: "Sucursal",
                        principalColumn: "CodigoSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Justificacion",
                columns: table => new
                {
                    CodigoJustificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoEmpleado = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoTipoJustificacion = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPermiso = table.Column<bool>(type: "bit", nullable: false),
                    IsFeriado = table.Column<bool>(type: "bit", nullable: false),
                    CodigoEstado = table.Column<int>(type: "int", nullable: false),
                    IsEliminado = table.Column<bool>(type: "bit", nullable: true),
                    CodigoUsuarioCreacion = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodigoUsuarioMod = table.Column<int>(type: "int", nullable: true),
                    FechaMod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodigoUsuarioElimina = table.Column<int>(type: "int", nullable: true),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Justificacion", x => x.CodigoJustificacion);
                    table.ForeignKey(
                        name: "FK_Justificacion_Empleado_CodigoEmpleado",
                        column: x => x.CodigoEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "CodigoEmpleado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Justificacion_TipoJustificacion_CodigoTipoJustificacion",
                        column: x => x.CodigoTipoJustificacion,
                        principalTable: "TipoJustificacion",
                        principalColumn: "CodigoTipoJustificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Marcacion",
                columns: table => new
                {
                    IdMarcacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodigoEmpleado = table.Column<int>(type: "int", nullable: false),
                    CodigoSucursal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcacion", x => x.IdMarcacion);
                    table.ForeignKey(
                        name: "FK_Marcacion_Empleado_CodigoEmpleado",
                        column: x => x.CodigoEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "CodigoEmpleado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Marcacion_Sucursal_CodigoSucursal",
                        column: x => x.CodigoSucursal,
                        principalTable: "Sucursal",
                        principalColumn: "CodigoSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Horario",
                columns: new[] { "CodigoHorario", "Descripcion", "Inicia", "IsActivo", "Termina" },
                values: new object[,]
                {
                    { 1, "Manana", new DateTime(1, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(1, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Tarde", new DateTime(1, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Sucursal",
                columns: new[] { "CodigoSucursal", "CodigoUsuarioCreacion", "CodigoUsuarioElimina", "CodigoUsuarioMod", "FechaCreacion", "FechaEliminacion", "FechaMod", "IsActivo", "IsEliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, null, null, new DateTime(2024, 9, 4, 23, 36, 33, 914, DateTimeKind.Local).AddTicks(5866), null, null, true, false, "Linda Vista" },
                    { 2, 1, null, null, new DateTime(2024, 9, 4, 23, 36, 33, 914, DateTimeKind.Local).AddTicks(5879), null, null, true, false, "Metrocentro" }
                });

            migrationBuilder.InsertData(
                table: "TipoJustificacion",
                columns: new[] { "CodigoTipoJustificacion", "Descripcion", "IsActiva", "IsFeriado", "IsSalida" },
                values: new object[,]
                {
                    { 1, "Dia Vacaciones", true, false, true },
                    { 2, "Horas Libre", true, false, true },
                    { 3, "Dia Feriado", true, false, true },
                    { 4, "Horas Extras", true, false, false }
                });

            migrationBuilder.InsertData(
                table: "Empleado",
                columns: new[] { "CodigoEmpleado", "Cedula", "CodigoHorario", "CodigoSucursal", "CodigoUsuarioCreacion", "CodigoUsuarioElimina", "CodigoUsuarioMod", "Contraseña", "FechaCreacion", "FechaEliminacion", "FechaMod", "IsActivo", "IsEliminado", "IsUsuario", "NombreEmpleado", "Usuario" },
                values: new object[] { 1, "", 1, 1, 1, null, null, "123", new DateTime(2024, 9, 4, 23, 36, 33, 914, DateTimeKind.Local).AddTicks(5915), null, null, true, false, true, "Admin", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_CodigoHorario",
                table: "Empleado",
                column: "CodigoHorario");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_CodigoSucursal",
                table: "Empleado",
                column: "CodigoSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Justificacion_CodigoEmpleado",
                table: "Justificacion",
                column: "CodigoEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Justificacion_CodigoTipoJustificacion",
                table: "Justificacion",
                column: "CodigoTipoJustificacion");

            migrationBuilder.CreateIndex(
                name: "IX_Marcacion_CodigoEmpleado",
                table: "Marcacion",
                column: "CodigoEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Marcacion_CodigoSucursal",
                table: "Marcacion",
                column: "CodigoSucursal");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CtoMarcacionesReporte");

            migrationBuilder.DropTable(
                name: "Justificacion");

            migrationBuilder.DropTable(
                name: "Marcacion");

            migrationBuilder.DropTable(
                name: "TipoJustificacion");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Horario");

            migrationBuilder.DropTable(
                name: "Sucursal");
        }
    }
}
