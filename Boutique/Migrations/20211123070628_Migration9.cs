using Microsoft.EntityFrameworkCore.Migrations;

namespace Boutique.Migrations
{
    public partial class Migration9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivraisonProduct");

            migrationBuilder.CreateTable(
                name: "ProductLivraison",
                columns: table => new
                {
                    ProductLivraisonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    LivraisonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLivraison", x => x.ProductLivraisonId);
                    table.ForeignKey(
                        name: "FK_ProductLivraison_Livraisons_LivraisonId",
                        column: x => x.LivraisonId,
                        principalTable: "Livraisons",
                        principalColumn: "LivraisonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductLivraison_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductLivraison_LivraisonId",
                table: "ProductLivraison",
                column: "LivraisonId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLivraison_ProductId",
                table: "ProductLivraison",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductLivraison");

            migrationBuilder.CreateTable(
                name: "LivraisonProduct",
                columns: table => new
                {
                    LivraisonsLivraisonId = table.Column<int>(type: "int", nullable: false),
                    ProductsProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivraisonProduct", x => new { x.LivraisonsLivraisonId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_LivraisonProduct_Livraisons_LivraisonsLivraisonId",
                        column: x => x.LivraisonsLivraisonId,
                        principalTable: "Livraisons",
                        principalColumn: "LivraisonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivraisonProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LivraisonProduct_ProductsProductId",
                table: "LivraisonProduct",
                column: "ProductsProductId");
        }
    }
}
