using Microsoft.EntityFrameworkCore.Migrations;

namespace VeiculosProjetoTeste.Migrations
{
    public partial class Inicial01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarroAcessorioId",
                table: "CarroAcessorio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarroAcessorioId",
                table: "CarroAcessorio",
                nullable: false,
                defaultValue: 0);
        }
    }
}
