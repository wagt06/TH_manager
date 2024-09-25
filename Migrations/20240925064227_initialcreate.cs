using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MD.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
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

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreMenu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreRol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolId);
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
                name: "MenusOpciones",
                columns: table => new
                {
                    MenuOpcionesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    NombreOpcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenusOpciones", x => x.MenuOpcionesId);
                    table.ForeignKey(
                        name: "FK_MenusOpciones_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolMenu",
                columns: table => new
                {
                    RolMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    IsActivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolMenu", x => x.RolMenuId);
                    table.ForeignKey(
                        name: "FK_RolMenu_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Restrict);
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
                name: "RolMenuOpciones",
                columns: table => new
                {
                    RolMenuOpcionesid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuOpcionesId = table.Column<int>(type: "int", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    RolMenuId = table.Column<int>(type: "int", nullable: false),
                    IsActivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolMenuOpciones", x => x.RolMenuOpcionesid);
                    table.ForeignKey(
                        name: "FK_RolMenuOpciones_RolMenu_RolMenuId",
                        column: x => x.RolMenuId,
                        principalTable: "RolMenu",
                        principalColumn: "RolMenuId",
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
                table: "Menu",
                columns: new[] { "MenuId", "Modulo", "NombreMenu" },
                values: new object[,]
                {
                    { 1, "Empleados", "Empleado" },
                    { 2, "Empleados", "Justificaciones" },
                    { 3, "Empleados", "Reportes" },
                    { 4, "Seguridad", "Roles" },
                    { 5, "Emmpresa", "Sucursales" }
                });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "RolId", "IsActivo", "NombreRol" },
                values: new object[] { 1, true, "Admin" });

            migrationBuilder.InsertData(
                table: "Sucursal",
                columns: new[] { "CodigoSucursal", "CodigoUsuarioCreacion", "CodigoUsuarioElimina", "CodigoUsuarioMod", "FechaCreacion", "FechaEliminacion", "FechaMod", "IsActivo", "IsEliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, null, null, new DateTime(2024, 9, 25, 0, 42, 27, 757, DateTimeKind.Local).AddTicks(5318), null, null, true, false, "Linda Vista" },
                    { 2, 1, null, null, new DateTime(2024, 9, 25, 0, 42, 27, 757, DateTimeKind.Local).AddTicks(5333), null, null, true, false, "Metrocentro" }
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
                table: "MenusOpciones",
                columns: new[] { "MenuOpcionesId", "MenuId", "NombreOpcion" },
                values: new object[,]
                {
                    { 1, 1, "Agregar" },
                    { 2, 1, "Modificar" },
                    { 3, 1, "Eliminar" },
                    { 4, 2, "Agregar" },
                    { 5, 2, "Modificar" },
                    { 6, 2, "Eliminar" },
                    { 7, 2, "Aprobar" },
                    { 8, 2, "Rechazar" }
                });

            migrationBuilder.InsertData(
                table: "RolMenu",
                columns: new[] { "RolMenuId", "IsActivo", "MenuId", "RolId" },
                values: new object[,]
                {
                    { 1, true, 1, 1 },
                    { 2, true, 2, 1 },
                    { 3, true, 3, 1 },
                    { 4, true, 4, 1 },
                    { 5, true, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "CodigoUsuarioCreacion", "CodigoUsuarioElimina", "CodigoUsuarioMod", "Contrasena", "CorreoElectronico", "FechaCreacion", "FechaEliminacion", "FechaMod", "IsEliminado", "Nombre", "RolId" },
                values: new object[] { 1, 1, null, null, "123", "", new DateTime(2024, 9, 25, 0, 42, 27, 757, DateTimeKind.Local).AddTicks(5439), null, null, false, "admin", 1 });

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

            migrationBuilder.CreateIndex(
                name: "IX_MenusOpciones_MenuId",
                table: "MenusOpciones",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_RolMenu_RolId",
                table: "RolMenu",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_RolMenuOpciones_RolMenuId",
                table: "RolMenuOpciones",
                column: "RolMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_RolId",
                table: "Usuario",
                column: "RolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Justificacion");

            migrationBuilder.DropTable(
                name: "Marcacion");

            migrationBuilder.DropTable(
                name: "MenusOpciones");

            migrationBuilder.DropTable(
                name: "RolMenuOpciones");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "TipoJustificacion");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "RolMenu");

            migrationBuilder.DropTable(
                name: "Horario");

            migrationBuilder.DropTable(
                name: "Sucursal");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
