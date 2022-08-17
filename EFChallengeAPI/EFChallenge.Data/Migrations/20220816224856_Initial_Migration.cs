using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFChallenge.Data.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddreessType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddreessType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentifierType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentifierType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemAddendum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KeyField = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAddendum", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemSubType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSubType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                    table.ForeignKey(
                        name: "FK_State_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identifier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentifierTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identifier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identifier_IdentifierType_IdentifierTypeId",
                        column: x => x.IdentifierTypeId,
                        principalTable: "IdentifierType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemTypeId = table.Column<int>(type: "int", nullable: false),
                    ItemStatusId = table.Column<int>(type: "int", nullable: false),
                    ItemSubTypeId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    ParentItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Item_ParentItemId",
                        column: x => x.ParentItemId,
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_ItemStatus_ItemStatusId",
                        column: x => x.ItemStatusId,
                        principalTable: "ItemStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_ItemSubType_ItemSubTypeId",
                        column: x => x.ItemSubTypeId,
                        principalTable: "ItemSubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_ItemType_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemContainerConstraint",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemTypeId = table.Column<int>(type: "int", nullable: false),
                    Min = table.Column<int>(type: "int", nullable: false),
                    Max = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemContainerConstraint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemContainerConstraint_ItemType_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "County",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_County", x => x.Id);
                    table.ForeignKey(
                        name: "FK_County_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemIdentifier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ItemIdentifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemIdentifier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemIdentifier_Identifier_ItemIdentifierId",
                        column: x => x.ItemIdentifierId,
                        principalTable: "Identifier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemIdentifier_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Line1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Line2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ZipPostalCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    City = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CountyId = table.Column<int>(type: "int", nullable: false),
                    AddressTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_AddreessType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "AddreessType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_County_CountyId",
                        column: x => x.CountyId,
                        principalTable: "County",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyAddress_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyAddress_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Country",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "USA" },
                    { 2, "Mexico" },
                    { 3, "Argentina" },
                    { 4, "Bolivia" }
                });

            migrationBuilder.InsertData(
                table: "IdentifierType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "NombreIdentifierType" });

            migrationBuilder.InsertData(
                table: "ItemAddendum",
                columns: new[] { "Id", "ItemId", "KeyField", "Value" },
                values: new object[] { new Guid("02a76c70-dafe-4550-afb1-01e610f72ce1"), new Guid("61b2f604-1e09-4b49-bafe-a7f0ee8dc0a5"), "NameKeyField", "Value001" });

            migrationBuilder.InsertData(
                table: "ItemStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "In Warehouse" },
                    { 2, "In Transit" },
                    { 3, "Delivered" }
                });

            migrationBuilder.InsertData(
                table: "ItemSubType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "NameItemsubType" });

            migrationBuilder.InsertData(
                table: "ItemType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Coke" },
                    { 2, "24 Cokes Package" },
                    { 3, "Box with 4 Cokes Package" }
                });

            migrationBuilder.InsertData(
                table: "Identifier",
                columns: new[] { "Id", "Data", "IdentifierTypeId" },
                values: new object[] { new Guid("1d847c14-4722-47c4-bacf-bf9d3523345f"), "Data test", 1 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "ItemStatusId", "ItemSubTypeId", "ItemTypeId", "LocationId", "ParentItemId" },
                values: new object[] { new Guid("61b2f604-1e09-4b49-bafe-a7f0ee8dc0a5"), 1, 1, 1, 1, new Guid("61b2f604-1e09-4b49-bafe-a7f0ee8dc0a5") });

            migrationBuilder.InsertData(
                table: "ItemContainerConstraint",
                columns: new[] { "Id", "ItemTypeId", "Max", "Min" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 2, 2 },
                    { 3, 3, 1, 1 }
                });

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
                table: "ItemIdentifier",
                columns: new[] { "Id", "ItemId", "ItemIdentifierId" },
                values: new object[] { 1, new Guid("61b2f604-1e09-4b49-bafe-a7f0ee8dc0a5"), new Guid("1d847c14-4722-47c4-bacf-bf9d3523345f") });

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

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId",
                table: "Address",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CountyId",
                table: "Address",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddress_AddressId",
                table: "CompanyAddress",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddress_CompanyId",
                table: "CompanyAddress",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_County_StateId",
                table: "County",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Identifier_IdentifierTypeId",
                table: "Identifier",
                column: "IdentifierTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemStatusId",
                table: "Item",
                column: "ItemStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemSubTypeId",
                table: "Item",
                column: "ItemSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemTypeId",
                table: "Item",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ParentItemId",
                table: "Item",
                column: "ParentItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemContainerConstraint_ItemTypeId",
                table: "ItemContainerConstraint",
                column: "ItemTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemIdentifier_ItemId",
                table: "ItemIdentifier",
                column: "ItemId",
                unique: true,
                filter: "[ItemId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ItemIdentifier_ItemIdentifierId",
                table: "ItemIdentifier",
                column: "ItemIdentifierId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemStatus_Name",
                table: "ItemStatus",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_State_CountryId",
                table: "State",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyAddress");

            migrationBuilder.DropTable(
                name: "ItemAddendum");

            migrationBuilder.DropTable(
                name: "ItemContainerConstraint");

            migrationBuilder.DropTable(
                name: "ItemIdentifier");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Identifier");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "AddreessType");

            migrationBuilder.DropTable(
                name: "County");

            migrationBuilder.DropTable(
                name: "IdentifierType");

            migrationBuilder.DropTable(
                name: "ItemStatus");

            migrationBuilder.DropTable(
                name: "ItemSubType");

            migrationBuilder.DropTable(
                name: "ItemType");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
