using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFChallenge.Data.Migrations
{
    public partial class AddForeingKeyCompanyIdToCompanyAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyAddress_Companies_AddressId",
                table: "CompanyAddress");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddress_CompanyId",
                table: "CompanyAddress",
                column: "CompanyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyAddress_Companies_CompanyId",
                table: "CompanyAddress",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyAddress_Companies_CompanyId",
                table: "CompanyAddress");

            migrationBuilder.DropIndex(
                name: "IX_CompanyAddress_CompanyId",
                table: "CompanyAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyAddress_Companies_AddressId",
                table: "CompanyAddress",
                column: "AddressId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
