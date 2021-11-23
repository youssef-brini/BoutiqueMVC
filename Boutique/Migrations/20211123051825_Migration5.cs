using Microsoft.EntityFrameworkCore.Migrations;

namespace Boutique.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Personnes_ClientPersonneId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventes_Personnes_ClientPersonneId",
                table: "Ventes");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Personnes_ClientPersonneId",
                table: "Products",
                column: "ClientPersonneId",
                principalTable: "Personnes",
                principalColumn: "PersonneId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventes_Personnes_ClientPersonneId",
                table: "Ventes",
                column: "ClientPersonneId",
                principalTable: "Personnes",
                principalColumn: "PersonneId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Personnes_ClientPersonneId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventes_Personnes_ClientPersonneId",
                table: "Ventes");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Personnes_ClientPersonneId",
                table: "Products",
                column: "ClientPersonneId",
                principalTable: "Personnes",
                principalColumn: "PersonneId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventes_Personnes_ClientPersonneId",
                table: "Ventes",
                column: "ClientPersonneId",
                principalTable: "Personnes",
                principalColumn: "PersonneId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
