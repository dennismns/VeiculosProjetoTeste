using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VeiculosProjetoTeste.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acessorio",
                columns: table => new
                {
                    AcessorioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acessorio", x => x.AcessorioId);
                });

            migrationBuilder.CreateTable(
                name: "Carro",
                columns: table => new
                {
                    CarroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DataCompra = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Cor = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro", x => x.CarroId);
                });

            migrationBuilder.CreateTable(
                name: "CarroAcessorio",
                columns: table => new
                {
                    CarroAcessorioId = table.Column<int>(nullable: false),
                    CarroId = table.Column<int>(nullable: false),
                    AcessorioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarroAcessorio", x => new { x.CarroId, x.AcessorioId });
                    table.ForeignKey(
                        name: "FK_CarroAcessorio_Acessorio_AcessorioId",
                        column: x => x.AcessorioId,
                        principalTable: "Acessorio",
                        principalColumn: "AcessorioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarroAcessorio_Carro_CarroId",
                        column: x => x.CarroId,
                        principalTable: "Carro",
                        principalColumn: "CarroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarroAcessorio_AcessorioId",
                table: "CarroAcessorio",
                column: "AcessorioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarroAcessorio");

            migrationBuilder.DropTable(
                name: "Acessorio");

            migrationBuilder.DropTable(
                name: "Carro");
        }
    }
}
