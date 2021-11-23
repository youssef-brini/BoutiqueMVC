using Microsoft.EntityFrameworkCore.Migrations;

namespace Boutique.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Personnes_EmployePersonneId",
                table: "Commandes");

            migrationBuilder.DropForeignKey(
                name: "FK_Livraisons_Personnes_EmployePersonneId",
                table: "Livraisons");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Commandes_CommandeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Ventes_VenteId",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Commandes_Personnes_EmployePersonneId",
                table: "Commandes",
                column: "EmployePersonneId",
                principalTable: "Personnes",
                principalColumn: "PersonneId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Livraisons_Personnes_EmployePersonneId",
                table: "Livraisons",
                column: "EmployePersonneId",
                principalTable: "Personnes",
                principalColumn: "PersonneId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Commandes_CommandeId",
                table: "Products",
                column: "CommandeId",
                principalTable: "Commandes",
                principalColumn: "CommandeId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Ventes_VenteId",
                table: "Products",
                column: "VenteId",
                principalTable: "Ventes",
                principalColumn: "VenteId",
                onDelete: ReferentialAction.SetNull);
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
                name: "FK_Products_Commandes_CommandeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Ventes_VenteId",
                table: "Products");

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
                name: "FK_Products_Commandes_CommandeId",
                table: "Products",
                column: "CommandeId",
                principalTable: "Commandes",
                principalColumn: "CommandeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Ventes_VenteId",
                table: "Products",
                column: "VenteId",
                principalTable: "Ventes",
                principalColumn: "VenteId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
