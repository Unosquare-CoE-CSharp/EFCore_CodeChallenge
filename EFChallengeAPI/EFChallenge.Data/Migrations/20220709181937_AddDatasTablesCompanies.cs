using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFChallenge.Data.Migrations
{
    public partial class AddDatasTablesCompanies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AddreessType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Phsycal Address" },
                    { 2, "IRS Address" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Unosquare" });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Oregon" },
                    { 2, 2, "Jalisco" }
                });

            migrationBuilder.InsertData(
                table: "County",
                columns: new[] { "Id", "Name", "StateId" },
                values: new object[] { 1, "Washington", 1 });

            migrationBuilder.InsertData(
                table: "County",
                columns: new[] { "Id", "Name", "StateId" },
                values: new object[] { 2, "Guadalajara", 2 });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "AddressTypeId", "City", "CountyId", "Line1", "Line2", "ZipPostalCode" },
                values: new object[] { 1, 2, "Portland", 1, "4800 Meadows Road, Suite 300 Lake Oswego", null, "97035" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "AddressTypeId", "City", "CountyId", "Line1", "Line2", "ZipPostalCode" },
                values: new object[] { 2, 1, "Guadalajara", 2, "Av. de las Américas 1536, Country Club", null, "44637" });

            migrationBuilder.InsertData(
                table: "CompanyAddress",
                columns: new[] { "Id", "AddressId", "CompanyId" },
                values: new object[] { 2, 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyAddress",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompanyAddress",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AddreessType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AddreessType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "County",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "County",
                keyColumn: "Id",
                keyValue: 2);

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
