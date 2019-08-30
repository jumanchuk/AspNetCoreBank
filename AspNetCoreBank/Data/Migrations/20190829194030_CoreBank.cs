using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreBank.Data.Migrations
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
                name: "MovementsType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Movements_type = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementsType", x => x.Id);
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
                    ClientId = table.Column<int>(nullable: false),
                    current_balance = table.Column<decimal>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    Opening_date = table.Column<DateTime>(nullable: false),
                    Closing_date = table.Column<DateTime>(nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductsId = table.Column<int>(nullable: false),
                    amount = table.Column<decimal>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    MovementsTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movements_MovementsType_MovementsTypeId",
                        column: x => x.MovementsTypeId,
                        principalTable: "MovementsType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movements_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Date", "Document", "Lastname", "Name" },
                values: new object[] { 1, new DateTime(2019, 8, 29, 16, 40, 29, 708, DateTimeKind.Local).AddTicks(7155), 95699120, "Umanchuk", "Jury" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Date", "Document", "Lastname", "Name" },
                values: new object[] { 2, new DateTime(2019, 8, 29, 16, 40, 29, 708, DateTimeKind.Local).AddTicks(7155), 95598062, "Perez", "Linda" });

            migrationBuilder.InsertData(
                table: "MovementsType",
                columns: new[] { "Id", "Movements_type", "name", "status" },
                values: new object[] { 1, 1, "Deposito", 1 });

            migrationBuilder.InsertData(
                table: "MovementsType",
                columns: new[] { "Id", "Movements_type", "name", "status" },
                values: new object[] { 2, 2, "Extracción", 1 });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Product_type", "name", "status" },
                values: new object[] { 1, 1, "Cuenta Ahorro", 1 });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Product_type", "name", "status" },
                values: new object[] { 2, 1, "Cuenta Corriente", 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClientId", "Closing_date", "Opening_date", "ProductTypeId", "current_balance", "status" },
                values: new object[] { 1, 1, null, new DateTime(2019, 8, 29, 16, 40, 29, 708, DateTimeKind.Local).AddTicks(7155), 1, 150m, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClientId", "Closing_date", "Opening_date", "ProductTypeId", "current_balance", "status" },
                values: new object[] { 3, 2, null, new DateTime(2019, 8, 29, 16, 40, 29, 708, DateTimeKind.Local).AddTicks(7155), 1, 500m, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClientId", "Closing_date", "Opening_date", "ProductTypeId", "current_balance", "status" },
                values: new object[] { 2, 1, null, new DateTime(2019, 8, 29, 16, 40, 29, 708, DateTimeKind.Local).AddTicks(7155), 2, 100m, 1 });

            migrationBuilder.InsertData(
                table: "Movements",
                columns: new[] { "Id", "MovementsTypeId", "ProductsId", "amount", "date", "status" },
                values: new object[] { 1, 1, 1, 150m, new DateTime(2019, 8, 29, 16, 40, 29, 708, DateTimeKind.Local).AddTicks(7155), 1 });

            migrationBuilder.InsertData(
                table: "Movements",
                columns: new[] { "Id", "MovementsTypeId", "ProductsId", "amount", "date", "status" },
                values: new object[] { 2, 2, 1, 100m, new DateTime(2019, 8, 29, 16, 40, 29, 708, DateTimeKind.Local).AddTicks(7155), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Movements_MovementsTypeId",
                table: "Movements",
                column: "MovementsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Movements_ProductsId",
                table: "Movements",
                column: "ProductsId");

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
                name: "Movements");

            migrationBuilder.DropTable(
                name: "MovementsType");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ProductTypes");
        }
    }
}
