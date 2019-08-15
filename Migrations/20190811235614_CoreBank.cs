using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreBank.Migrations
{
    public partial class CoreBank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Document = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Product_type = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    current_balance = table.Column<decimal>(nullable: false),
                    status = table.Column<decimal>(nullable: false),
                    Opening_date = table.Column<DateTime>(nullable: false),
                    Closing_date = table.Column<DateTime>(nullable: true),
                    ClientId = table.Column<int>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Date", "Document", "Lastname", "Name" },
                values: new object[] { 1, new DateTime(2019, 8, 11, 20, 56, 13, 951, DateTimeKind.Local), 95699120, "Umanchuk", "Jury" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Date", "Document", "Lastname", "Name" },
                values: new object[] { 2, new DateTime(2019, 8, 11, 20, 56, 13, 957, DateTimeKind.Local), 95885263, "Perez", "Linda" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Product_type", "name", "status" },
                values: new object[] { 1, 1, "Cuenta Ahorro", 1 });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Product_type", "name", "status" },
                values: new object[] { 2, 1, "Cuenta Corriente", 2 });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Product_type", "name", "status" },
                values: new object[] { 3, 2, "Prestamo Personal", 3 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClientId", "Closing_date", "Opening_date", "ProductTypeId", "current_balance", "status" },
                values: new object[] { 1, 1, null, new DateTime(2019, 8, 11, 20, 56, 13, 958, DateTimeKind.Local), 1, 0m, 1m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClientId", "Closing_date", "Opening_date", "ProductTypeId", "current_balance", "status" },
                values: new object[] { 2, 1, null, new DateTime(2019, 8, 11, 20, 56, 13, 959, DateTimeKind.Local), 2, 0m, 1m });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ClientId",
                table: "Products",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ProductTypes");
        }
    }
}
