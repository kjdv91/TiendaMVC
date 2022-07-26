using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tienda.Migrations
{
    public partial class NuevoModelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoAplication",
                columns: table => new
                {
                    IdTipoAplicacion = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreAplicacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAplication", x => x.IdTipoAplicacion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoAplication");
        }
    }
}
