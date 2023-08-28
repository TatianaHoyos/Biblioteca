using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.Migrations
{
    public partial class Prestamo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NúmeroTeléfono",
                table: "Usuarios",
                newName: "NumeroTelefono");

            migrationBuilder.RenameColumn(
                name: "Dirección",
                table: "Usuarios",
                newName: "Direccion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumeroTelefono",
                table: "Usuarios",
                newName: "NúmeroTeléfono");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Usuarios",
                newName: "Dirección");
        }
    }
}
