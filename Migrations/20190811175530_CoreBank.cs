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
                    Id = table.Column<Guid>(nullable: false),
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Document = table.Column<int>(nullable: false),
                    Product_id = table.Column<long>(nullable: false),
                    Product_type = table.Column<int>(nullable: false),
                    current_balance = table.Column<decimal>(nullable: false),
                    status = table.Column<decimal>(nullable: false),
                    Opening_date = table.Column<DateTime>(nullable: false),
                    Closing_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Product_type = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Date", "Document", "Lastname", "Name" },
                values: new object[] { new Guid("025254af-24fa-4566-b67d-0b0e29e906a5"), new DateTime(2019, 8, 11, 14, 55, 29, 959, DateTimeKind.Local).AddTicks(8560), 95699120, "Umanchuk", "Jury" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Date", "Document", "Lastname", "Name" },
                values: new object[] { new Guid("986ec1ef-3e95-4871-b397-30cccdac6c88"), new DateTime(2019, 8, 11, 14, 55, 29, 960, DateTimeKind.Local).AddTicks(6186), 95885263, "Perez", "Linda" });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "Id", "Product_type", "name", "status" },
                values: new object[] { new Guid("5fdf6ab0-2727-4d4e-87dc-50843c3827da"), 1, "Cuenta Ahorro", 1 });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "Id", "Product_type", "name", "status" },
                values: new object[] { new Guid("69fef123-bd64-45cb-a6c5-8995d849c8ac"), 1, "Cuenta Corriente", 2 });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "Id", "Product_type", "name", "status" },
                values: new object[] { new Guid("14fc858f-cb50-46ec-9dfd-5eccf18af068"), 2, "Prestamo Personal", 3 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Closing_date", "Document", "Opening_date", "Product_id", "Product_type", "current_balance", "status" },
                values: new object[] { new Guid("c44b5b8e-6272-4f42-b1ce-e1dba25e1f33"), null, 95699120, new DateTime(2019, 8, 11, 14, 55, 29, 961, DateTimeKind.Local).AddTicks(9790), 7534563210L, 1, 0m, 1m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Closing_date", "Document", "Opening_date", "Product_id", "Product_type", "current_balance", "status" },
                values: new object[] { new Guid("077a0b92-9c7d-4aec-a4c8-5c3aebcbf650"), null, 95699120, new DateTime(2019, 8, 11, 14, 55, 29, 962, DateTimeKind.Local).AddTicks(339), 7547854268L, 2, 0m, 1m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductType");
        }
    }
}
