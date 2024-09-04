using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MD.Migrations
{
    /// <inheritdoc />
    public partial class modif_Just_add_isPermiso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaHoraInicial",
                table: "Justificacion",
                newName: "HoraInicial");

            migrationBuilder.RenameColumn(
                name: "FechaHoraFinal",
                table: "Justificacion",
                newName: "HoraFinal");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Justificacion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsPermiso",
                table: "Justificacion",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Justificacion");

            migrationBuilder.DropColumn(
                name: "IsPermiso",
                table: "Justificacion");

            migrationBuilder.RenameColumn(
                name: "HoraInicial",
                table: "Justificacion",
                newName: "FechaHoraInicial");

            migrationBuilder.RenameColumn(
                name: "HoraFinal",
                table: "Justificacion",
                newName: "FechaHoraFinal");
        }
    }
}
