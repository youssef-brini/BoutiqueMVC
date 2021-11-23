using Microsoft.EntityFrameworkCore.Migrations;

namespace Boutique.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientPersonneId",
                table: "Ventes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientPersonneId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommandeId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VenteId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "Personnes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployePersonneId",
                table: "Livraisons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployePersonneId",
                table: "Commandes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CommandeFournisseur",
                columns: table => new
                {
                    CommandesCommandeId = table.Column<int>(type: "int", nullable: false),
                    FournisseursPersonneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandeFournisseur", x => new { x.CommandesCommandeId, x.FournisseursPersonneId });
                    table.ForeignKey(
                        name: "FK_CommandeFournisseur_Commandes_CommandesCommandeId",
                        column: x => x.CommandesCommandeId,
                        principalTable: "Commandes",
                        principalColumn: "CommandeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommandeFournisseur_Personnes_FournisseursPersonneId",
                        column: x => x.FournisseursPersonneId,
                        principalTable: "Personnes",
                        principalColumn: "PersonneId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_Ventes_ClientPersonneId",
                table: "Ventes",
                column: "ClientPersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ClientPersonneId",
                table: "Products",
                column: "ClientPersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CommandeId",
                table: "Products",
                column: "CommandeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StockId",
                table: "Products",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_VenteId",
                table: "Products",
                column: "VenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_StockId",
                table: "Personnes",
                column: "StockId",
                unique: true,
                filter: "[StockId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Livraisons_EmployePersonneId",
                table: "Livraisons",
                column: "EmployePersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_EmployePersonneId",
                table: "Commandes",
                column: "EmployePersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_CommandeFournisseur_FournisseursPersonneId",
                table: "CommandeFournisseur",
                column: "FournisseursPersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_FournisseurProduct_ProductsProductId",
                table: "FournisseurProduct",
                column: "ProductsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LivraisonProduct_ProductsProductId",
                table: "LivraisonProduct",
                column: "ProductsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commandes_Personnes_EmployePersonneId",
                table: "Commandes",
                column: "EmployePersonneId",
                principalTable: "Personnes",
                principalColumn: "PersonneId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Livraisons_Personnes_EmployePersonneId",
                table: "Livraisons",
                column: "EmployePersonneId",
                principalTable: "Personnes",
                principalColumn: "PersonneId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnes_Stocks_StockId",
                table: "Personnes",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "StockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Commandes_CommandeId",
                table: "Products",
                column: "CommandeId",
                principalTable: "Commandes",
                principalColumn: "CommandeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Personnes_ClientPersonneId",
                table: "Products",
                column: "ClientPersonneId",
                principalTable: "Personnes",
                principalColumn: "PersonneId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Stocks_StockId",
                table: "Products",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "StockId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Ventes_VenteId",
                table: "Products",
                column: "VenteId",
                principalTable: "Ventes",
                principalColumn: "VenteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventes_Personnes_ClientPersonneId",
                table: "Ventes",
                column: "ClientPersonneId",
                principalTable: "Personnes",
                principalColumn: "PersonneId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Personnes_EmployePersonneId",
                table: "Commandes");

            migrationBuilder.DropForeignKey(
                name: "FK_Livraisons_Personnes_EmployePersonneId",
                table: "Livraisons");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnes_Stocks_StockId",
                table: "Personnes");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Commandes_CommandeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Personnes_ClientPersonneId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Stocks_StockId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Ventes_VenteId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventes_Personnes_ClientPersonneId",
                table: "Ventes");

            migrationBuilder.DropTable(
                name: "CommandeFournisseur");

            migrationBuilder.DropTable(
                name: "FournisseurProduct");

            migrationBuilder.DropTable(
                name: "LivraisonProduct");

            migrationBuilder.DropIndex(
                name: "IX_Ventes_ClientPersonneId",
                table: "Ventes");

            migrationBuilder.DropIndex(
                name: "IX_Products_ClientPersonneId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CommandeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_StockId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_VenteId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Personnes_StockId",
                table: "Personnes");

            migrationBuilder.DropIndex(
                name: "IX_Livraisons_EmployePersonneId",
                table: "Livraisons");

            migrationBuilder.DropIndex(
                name: "IX_Commandes_EmployePersonneId",
                table: "Commandes");

            migrationBuilder.DropColumn(
                name: "ClientPersonneId",
                table: "Ventes");

            migrationBuilder.DropColumn(
                name: "ClientPersonneId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CommandeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VenteId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "EmployePersonneId",
                table: "Livraisons");

            migrationBuilder.DropColumn(
                name: "EmployePersonneId",
                table: "Commandes");
        }
    }
}
