using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVenda.Repositorio.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIA",
                columns: table => new
                {
                    CODIGO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIA", x => x.CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "CLIENTE",
                columns: table => new
                {
                    CODIGO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    CPF_CNPJ = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    EMAIL = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    CELULAR = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTE", x => x.CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    CODIGO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    EMAIL = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    SENHA = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTO",
                columns: table => new
                {
                    CODIGO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    QUANTIDADE = table.Column<double>(nullable: false),
                    VALOR = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    CODIGO_CATEGORIA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTO", x => x.CODIGO);
                    table.ForeignKey(
                        name: "FK_PRODUTO_CATEGORIA_CODIGO_CATEGORIA",
                        column: x => x.CODIGO_CATEGORIA,
                        principalTable: "CATEGORIA",
                        principalColumn: "CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VENDA",
                columns: table => new
                {
                    CODIGO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false),
                    CODIGO_CLIENTE = table.Column<int>(nullable: false),
                    TOTAL = table.Column<decimal>(type: "decimal(9,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENDA", x => x.CODIGO);
                    table.ForeignKey(
                        name: "FK_VENDA_CLIENTE_CODIGO_CLIENTE",
                        column: x => x.CODIGO_CLIENTE,
                        principalTable: "CLIENTE",
                        principalColumn: "CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VENDA_PRODUTOS",
                columns: table => new
                {
                    CODIGO_VENDA = table.Column<int>(nullable: false),
                    CODIGO_PRODUTO = table.Column<int>(nullable: false),
                    QUANTIDADE = table.Column<double>(nullable: false),
                    VALOR_UNITARIO = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    VALOR_TOTAL = table.Column<decimal>(type: "decimal(9,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENDA_PRODUTOS", x => new { x.CODIGO_PRODUTO, x.CODIGO_VENDA });
                    table.ForeignKey(
                        name: "FK_VENDA_PRODUTO_PRODUTO_CODIGO_PRODUTO",
                        column: x => x.CODIGO_PRODUTO,
                        principalTable: "PRODUTO",
                        principalColumn: "CODIGO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VENDA_PRODUTO_VENDA_CODIGO_VENDA",
                        column: x => x.CODIGO_VENDA,
                        principalTable: "VENDA",
                        principalColumn: "CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_CODIGO_CATEGORIA",
                table: "PRODUTO",
                column: "CODIGO_CATEGORIA");

            migrationBuilder.CreateIndex(
                name: "IX_VENDA_CODIGO_CLIENTE",
                table: "VENDA",
                column: "CODIGO_CLIENTE");

            migrationBuilder.CreateIndex(
                name: "IX_VENDA_PRODUTOS_CODIGO_VENDA",
                table: "VENDA_PRODUTOS",
                column: "CODIGO_VENDA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USUARIO");

            migrationBuilder.DropTable(
                name: "VENDA_PRODUTOS");

            migrationBuilder.DropTable(
                name: "PRODUTO");

            migrationBuilder.DropTable(
                name: "VENDA");

            migrationBuilder.DropTable(
                name: "CATEGORIA");

            migrationBuilder.DropTable(
                name: "CLIENTE");
        }
    }
}
