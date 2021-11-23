using Microsoft.EntityFrameworkCore.Migrations;

namespace Boutique.Migrations
{
    public partial class Migration10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommandeFournisseur");

            migrationBuilder.CreateTable(
                name: "FournisseurCommande",
                columns: table => new
                {
                    FournisseurCommandeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FournisseurId = table.Column<int>(type: "int", nullable: false),
                    CommandeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FournisseurCommande", x => x.FournisseurCommandeId);
                    table.ForeignKey(
                        name: "FK_FournisseurCommande_Commandes_CommandeId",
                        column: x => x.CommandeId,
                        principalTable: "Commandes",
                        principalColumn: "CommandeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FournisseurCommande_Personnes_FournisseurId",
                        column: x => x.FournisseurId,
                        principalTable: "Personnes",
                        principalColumn: "PersonneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FournisseurCommande_CommandeId",
                table: "FournisseurCommande",
                column: "CommandeId");

            migrationBuilder.CreateIndex(
                name: "IX_FournisseurCommande_FournisseurId",
                table: "FournisseurCommande",
                column: "FournisseurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FournisseurCommande");

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

            migrationBuilder.CreateIndex(
                name: "IX_CommandeFournisseur_FournisseursPersonneId",
                table: "CommandeFournisseur",
                column: "FournisseursPersonneId");
        }
    }
}
