using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesTop.Migrations
{
    public partial class CarrinhoCompraItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_CarrinhoCompraItens",
                columns: table => new
                {
                    CarrinhoCompraItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LancheId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CarrinhoCompraId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_CarrinhoCompraItens", x => x.CarrinhoCompraItemId);
                    table.ForeignKey(
                        name: "FK_tb_CarrinhoCompraItens_tb_Lanches_LancheId",
                        column: x => x.LancheId,
                        principalTable: "tb_Lanches",
                        principalColumn: "LancheId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_CarrinhoCompraItens_LancheId",
                table: "tb_CarrinhoCompraItens",
                column: "LancheId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_CarrinhoCompraItens");
        }
    }
}
