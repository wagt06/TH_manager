using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MD.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Empleado",
                columns: table => new
                {
                    CodigoEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoSucursal = table.Column<int>(type: "int", nullable: false),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                        name: "FK_Empleado_Sucursal_CodigoSucursal",
                        column: x => x.CodigoSucursal,
                        principalTable: "Sucursal",
                        principalColumn: "CodigoSucursal",
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
                    EmpleadoCodigoEmpleado = table.Column<int>(type: "int", nullable: false),
                    CodigoSucursal = table.Column<int>(type: "int", nullable: false),
                    SucursalCodigoSucursal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcacion", x => x.IdMarcacion);
                    table.ForeignKey(
                        name: "FK_Marcacion_Empleado_EmpleadoCodigoEmpleado",
                        column: x => x.EmpleadoCodigoEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "CodigoEmpleado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Marcacion_Sucursal_SucursalCodigoSucursal",
                        column: x => x.SucursalCodigoSucursal,
                        principalTable: "Sucursal",
                        principalColumn: "CodigoSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_CodigoSucursal",
                table: "Empleado",
                column: "CodigoSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Marcacion_EmpleadoCodigoEmpleado",
                table: "Marcacion",
                column: "EmpleadoCodigoEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Marcacion_SucursalCodigoSucursal",
                table: "Marcacion",
                column: "SucursalCodigoSucursal");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marcacion");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Sucursal");
        }
    }
}
