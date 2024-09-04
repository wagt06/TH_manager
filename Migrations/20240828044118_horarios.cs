using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MD.Migrations
{
    /// <inheritdoc />
    public partial class horarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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



                        migrationBuilder.AddColumn<int>(
                            name: "CodigoHorario",
                            table: "Empleado",
                            type: "int",
                            nullable: false,
                            defaultValue: 0);

                        migrationBuilder.CreateIndex(
            name: "IX_Empleado_CodigoHorario",
            table: "Empleado",
            column: "CodigoHorario");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Horario_CodigoHorario",
                table: "Empleado",
                column: "CodigoHorario",
                principalTable: "Horario",
                principalColumn: "CodigoHorario",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Horario_CodigoHorario",
                table: "Empleado");

            migrationBuilder.DropTable(
                name: "Horario");

            migrationBuilder.DropIndex(
                name: "IX_Empleado_CodigoHorario",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "CodigoHorario",
                table: "Empleado");
        }
    }
}
