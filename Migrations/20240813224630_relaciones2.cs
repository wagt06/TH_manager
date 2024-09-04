using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MD.Migrations
{
    /// <inheritdoc />
    public partial class relaciones2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsUsuario",
                table: "Empleado",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Empleado",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CtoMarcacionesReporte",
                columns: table => new
                {
                    CodigoEmpleado = table.Column<int>(type: "int", nullable: false),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoSucursal = table.Column<int>(type: "int", nullable: false),
                    Sucursal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Entrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salida = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CtoMarcacionesReporte");

            migrationBuilder.DropColumn(
                name: "IsUsuario",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Empleado");
        }
    }
}
