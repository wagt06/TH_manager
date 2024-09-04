using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MD.Migrations
{
    /// <inheritdoc />
    public partial class Justificacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Salida",
                table: "CtoMarcacionesReporte",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Entrada",
                table: "CtoMarcacionesReporte",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "TipoJustificacion",
                columns: table => new
                {
                    CodigoTipoJustificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFeriado = table.Column<bool>(type: "bit", nullable: false),
                    IsTiempoExtra = table.Column<bool>(type: "bit", nullable: false),
                    IsActiva = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoJustificacion", x => x.CodigoTipoJustificacion);
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
                    FechaHoraInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaHoraFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horas = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_Justificacion_CodigoEmpleado",
                table: "Justificacion",
                column: "CodigoEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Justificacion_CodigoTipoJustificacion",
                table: "Justificacion",
                column: "CodigoTipoJustificacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Justificacion");

            migrationBuilder.DropTable(
                name: "TipoJustificacion");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Salida",
                table: "CtoMarcacionesReporte",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Entrada",
                table: "CtoMarcacionesReporte",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
