using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreBank.Migrations
{
    public partial class AddClients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
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
                columns: new[] { "Id", "Date", "Lastname", "Name" },
                values: new object[] { new Guid("32ec5934-0864-4615-a9bc-4a95e437c8ea"), new DateTime(2019, 8, 6, 15, 8, 48, 732, DateTimeKind.Local), "Umanchuk", "Jury" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Date", "Lastname", "Name" },
                values: new object[] { new Guid("993d74a1-4445-46b4-885c-47f427bf99d5"), new DateTime(2019, 8, 6, 15, 8, 48, 732, DateTimeKind.Local), "Perez", "Linda" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
