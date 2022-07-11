using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFChallenge.Data.Migrations
{
    public partial class AddDataCountryWithAssembly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Company",
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Country",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Argentina" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Country",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.InsertData(
                table: "AddreessType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Phsycal Address" },
                    { 2, "IRS Address" }
                });

            migrationBuilder.InsertData(
                table: "Company",
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
    }
}
