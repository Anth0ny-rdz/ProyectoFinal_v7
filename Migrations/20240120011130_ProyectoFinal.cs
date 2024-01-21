using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_.Migrations
{
    public partial class ProyectoFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sede",
                columns: table => new
                {
                    SedeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCiudad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sede", x => x.SedeID);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    EmpleadoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargoEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EdadEmpleado = table.Column<int>(type: "int", nullable: false),
                    SueldoEmpleado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SedeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.EmpleadoID);
                    table.ForeignKey(
                        name: "FK_Empleado_Sede_SedeID",
                        column: x => x.SedeID,
                        principalTable: "Sede",
                        principalColumn: "SedeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_SedeID",
                table: "Empleado",
                column: "SedeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Sede");
        }
    }
}
