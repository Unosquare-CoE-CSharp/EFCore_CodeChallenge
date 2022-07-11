using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFChallenge.Data.Migrations
{
    public partial class AddItemTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyAddress_Companies_CompanyId",
                table: "CompanyAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DeleteData(
                table: "CompanyAddress",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "IdentifierType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "ItemSubtype",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSubtype", x => x.Id);
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
                name: "Identifiers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentifierTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identifiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identifiers_IdentifierType_IdentifierTypeId",
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
                    LocationId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Item_ItemSubtype_ItemSubTypeId",
                        column: x => x.ItemSubTypeId,
                        principalTable: "ItemSubtype",
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
                name: "ItemIdentifier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemIdentifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemIdentifier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemIdentifier_Identifiers_ItemIdentifierId",
                        column: x => x.ItemIdentifierId,
                        principalTable: "Identifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemIdentifier_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Identifiers_IdentifierTypeId",
                table: "Identifiers",
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
                unique: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyAddress_Company_CompanyId",
                table: "CompanyAddress",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyAddress_Company_CompanyId",
                table: "CompanyAddress");

            migrationBuilder.DropTable(
                name: "ItemAddendum");

            migrationBuilder.DropTable(
                name: "ItemContainerConstraint");

            migrationBuilder.DropTable(
                name: "ItemIdentifier");

            migrationBuilder.DropTable(
                name: "Identifiers");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "IdentifierType");

            migrationBuilder.DropTable(
                name: "ItemStatus");

            migrationBuilder.DropTable(
                name: "ItemSubtype");

            migrationBuilder.DropTable(
                name: "ItemType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DeleteData(
                table: "CompanyAddress",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyAddress_Companies_CompanyId",
                table: "CompanyAddress",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
