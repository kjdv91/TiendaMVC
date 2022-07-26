using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tienda.Migrations
{
    public partial class Two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreCtegoria",
                table: "Category",
                newName: "NombreCategoria");

            migrationBuilder.AlterColumn<string>(
                name: "NombreAplicacion",
                table: "TipoAplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreCategoria",
                table: "Category",
                newName: "NombreCtegoria");

            migrationBuilder.AlterColumn<string>(
                name: "NombreAplicacion",
                table: "TipoAplication",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
