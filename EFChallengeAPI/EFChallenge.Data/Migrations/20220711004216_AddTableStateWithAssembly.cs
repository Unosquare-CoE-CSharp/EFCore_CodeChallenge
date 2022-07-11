using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFChallenge.Data.Migrations
{
    public partial class AddTableStateWithAssembly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 1, 1, "Oregon" });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 2, 2, "Jalisco" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
