using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreBank.Migrations
{
    public partial class Clients : Migration
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

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Date", "Document", "Lastname", "Name" },
                values: new object[] { new Guid("7a42605e-f063-4318-a2dd-6676a8838bcf"), new DateTime(2019, 8, 7, 17, 19, 50, 799, DateTimeKind.Local), 95699120, "Umanchuk", "Jury" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Date", "Document", "Lastname", "Name" },
                values: new object[] { new Guid("78461615-92f6-497d-aa2c-c296b24b6978"), new DateTime(2019, 8, 7, 17, 19, 50, 799, DateTimeKind.Local), 95885263, "Perez", "Linda" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
