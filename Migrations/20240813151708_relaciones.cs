using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MD.Migrations
{
    /// <inheritdoc />
    public partial class relaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marcacion_Empleado_EmpleadoCodigoEmpleado",
                table: "Marcacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Marcacion_Sucursal_SucursalCodigoSucursal",
                table: "Marcacion");

            migrationBuilder.DropIndex(
                name: "IX_Marcacion_EmpleadoCodigoEmpleado",
                table: "Marcacion");

            migrationBuilder.DropIndex(
                name: "IX_Marcacion_SucursalCodigoSucursal",
                table: "Marcacion");

            migrationBuilder.DropColumn(
                name: "EmpleadoCodigoEmpleado",
                table: "Marcacion");

            migrationBuilder.DropColumn(
                name: "SucursalCodigoSucursal",
                table: "Marcacion");

            migrationBuilder.CreateIndex(
                name: "IX_Marcacion_CodigoEmpleado",
                table: "Marcacion",
                column: "CodigoEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Marcacion_CodigoSucursal",
                table: "Marcacion",
                column: "CodigoSucursal");

            migrationBuilder.AddForeignKey(
                name: "FK_Marcacion_Empleado_CodigoEmpleado",
                table: "Marcacion",
                column: "CodigoEmpleado",
                principalTable: "Empleado",
                principalColumn: "CodigoEmpleado",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Marcacion_Sucursal_CodigoSucursal",
                table: "Marcacion",
                column: "CodigoSucursal",
                principalTable: "Sucursal",
                principalColumn: "CodigoSucursal",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marcacion_Empleado_CodigoEmpleado",
                table: "Marcacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Marcacion_Sucursal_CodigoSucursal",
                table: "Marcacion");

            migrationBuilder.DropIndex(
                name: "IX_Marcacion_CodigoEmpleado",
                table: "Marcacion");

            migrationBuilder.DropIndex(
                name: "IX_Marcacion_CodigoSucursal",
                table: "Marcacion");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoCodigoEmpleado",
                table: "Marcacion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SucursalCodigoSucursal",
                table: "Marcacion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Marcacion_EmpleadoCodigoEmpleado",
                table: "Marcacion",
                column: "EmpleadoCodigoEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Marcacion_SucursalCodigoSucursal",
                table: "Marcacion",
                column: "SucursalCodigoSucursal");

            migrationBuilder.AddForeignKey(
                name: "FK_Marcacion_Empleado_EmpleadoCodigoEmpleado",
                table: "Marcacion",
                column: "EmpleadoCodigoEmpleado",
                principalTable: "Empleado",
                principalColumn: "CodigoEmpleado",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Marcacion_Sucursal_SucursalCodigoSucursal",
                table: "Marcacion",
                column: "SucursalCodigoSucursal",
                principalTable: "Sucursal",
                principalColumn: "CodigoSucursal",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
