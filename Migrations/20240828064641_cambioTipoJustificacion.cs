using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MD.Migrations
{
    /// <inheritdoc />
    public partial class cambioTipoJustificacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsTiempoExtra",
                table: "TipoJustificacion",
                newName: "IsSalida");


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
                    { 1, 1, null, null, new DateTime(2024, 8, 28, 0, 46, 41, 118, DateTimeKind.Local).AddTicks(7386), null, null, true, false, "Linda Vista" },
                    { 2, 1, null, null, new DateTime(2024, 8, 28, 0, 46, 41, 118, DateTimeKind.Local).AddTicks(7396), null, null, true, false, "Metrocentro" }
                });

            migrationBuilder.InsertData(
                table: "TipoJustificacion",
                columns: new[] { "CodigoTipoJustificacion", "Descripcion", "IsActiva", "IsFeriado", "IsSalida" },
                values: new object[,]
                {
                    { 1, "Dia Vacaciones", true, false, false },
                    { 2, "Horas Libre", true, false, false },
                    { 3, "Dia Feriado", true, true, false },
                    { 4, "Horas Extras", true, false, true }
                });

            migrationBuilder.InsertData(
                table: "Empleado",
                columns: new[] { "CodigoEmpleado", "Cedula", "CodigoHorario", "CodigoSucursal", "CodigoUsuarioCreacion", "CodigoUsuarioElimina", "CodigoUsuarioMod", "Contraseña", "FechaCreacion", "FechaEliminacion", "FechaMod", "IsActivo", "IsEliminado", "IsUsuario", "NombreEmpleado", "Usuario" },
                values: new object[,]
                {
                    { 1, "0011810860021C", 1, 1, 1, null, null, "123", new DateTime(2024, 8, 28, 0, 46, 41, 118, DateTimeKind.Local).AddTicks(7434), null, null, true, false, true, "William Gonzalez", "wagt06" },
                    { 2, "0011810860021C", 1, 1, 1, null, null, "123", new DateTime(2024, 8, 28, 0, 46, 41, 118, DateTimeKind.Local).AddTicks(7439), null, null, true, false, false, "Bayardo Gonzalez", "bagt06" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CtoMarcacionesReporte");

            migrationBuilder.DeleteData(
                table: "Empleado",
                keyColumn: "CodigoEmpleado",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Empleado",
                keyColumn: "CodigoEmpleado",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Horario",
                keyColumn: "CodigoHorario",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sucursal",
                keyColumn: "CodigoSucursal",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoJustificacion",
                keyColumn: "CodigoTipoJustificacion",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoJustificacion",
                keyColumn: "CodigoTipoJustificacion",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoJustificacion",
                keyColumn: "CodigoTipoJustificacion",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoJustificacion",
                keyColumn: "CodigoTipoJustificacion",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Horario",
                keyColumn: "CodigoHorario",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sucursal",
                keyColumn: "CodigoSucursal",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "IsSalida",
                table: "TipoJustificacion",
                newName: "IsTiempoExtra");
        }
    }
}
