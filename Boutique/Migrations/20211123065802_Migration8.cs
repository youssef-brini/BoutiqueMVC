using Microsoft.EntityFrameworkCore.Migrations;

namespace Boutique.Migrations
{
    public partial class Migration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FournisseurProduct");

            migrationBuilder.CreateTable(
                name: "ProductFournisseur",
                columns: table => new
                {
                    ProductFournisseurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    FournisseurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFournisseur", x => x.ProductFournisseurId);
                    table.ForeignKey(
                        name: "FK_ProductFournisseur_Personnes_FournisseurId",
                        column: x => x.FournisseurId,
                        principalTable: "Personnes",
                        principalColumn: "PersonneId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFournisseur_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFournisseur_FournisseurId",
                table: "ProductFournisseur",
                column: "FournisseurId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFournisseur_ProductId",
                table: "ProductFournisseur",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductFournisseur");

            migrationBuilder.CreateTable(
                name: "FournisseurProduct",
                columns: table => new
                {
                    FournisseursPersonneId = table.Column<int>(type: "int", nullable: false),
                    ProductsProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FournisseurProduct", x => new { x.FournisseursPersonneId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_FournisseurProduct_Personnes_FournisseursPersonneId",
                        column: x => x.FournisseursPersonneId,
                        principalTable: "Personnes",
                        principalColumn: "PersonneId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FournisseurProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FournisseurProduct_ProductsProductId",
                table: "FournisseurProduct",
                column: "ProductsProductId");
        }
    }
}
