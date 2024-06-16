using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IIS.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("d83b82d3-090e-41c6-b4f2-a106bd5af9c7"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("f2036e9a-a8b6-479c-9f87-0451889439d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45bf8340-f203-46de-ac5f-5a7f59f2103e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"));

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "Author", "Date", "Description", "Email", "NormalizedEmail", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"), "Author 1", new DateTime(2024, 6, 15, 16, 46, 35, 417, DateTimeKind.Local).AddTicks(3075), "Description 1", "email1@gmail.com", "email1@gmail.com", "+375 (29) 111-11-11" },
                    { new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"), "Author 2", new DateTime(2024, 6, 15, 16, 46, 35, 417, DateTimeKind.Local).AddTicks(3086), "Description 2", "email2@gmail.com", "email2@gmail.com", "+375 (29) 222-22-22" }
                });

            migrationBuilder.InsertData(
                table: "Serveces",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0d0a0af4-b852-4f12-bc4c-c827d264a53b"), 3, 109m, "description 2", "service 2" },
                    { new Guid("2e8b35c1-20cc-41c1-8665-447f404467f8"), 5, 159m, "description 1", "service 1" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 15, 16, 46, 35, 412, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 15, 16, 46, 35, 412, DateTimeKind.Local).AddTicks(9168));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("0d0a0af4-b852-4f12-bc4c-c827d264a53b"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("2e8b35c1-20cc-41c1-8665-447f404467f8"));

            migrationBuilder.InsertData(
                table: "Serveces",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("d83b82d3-090e-41c6-b4f2-a106bd5af9c7"), 5, 159m, "description 1", "service 1" },
                    { new Guid("f2036e9a-a8b6-479c-9f87-0451889439d4"), 3, 109m, "description 2", "service 2" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 14, 20, 5, 39, 985, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 14, 20, 5, 39, 985, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "DateOfBirth", "Discriminator", "Email", "Gender", "Name", "NormalizedEmail", "Password", "Patronymic", "PhoneNumber", "Position", "Surname" },
                values: new object[,]
                {
                    { new Guid("45bf8340-f203-46de-ac5f-5a7f59f2103e"), "City 4", "Country 4", new DateTime(1974, 6, 14, 20, 5, 39, 989, DateTimeKind.Local).AddTicks(6148), "Specialist", "email4@gmail.com", 2, "Name 4", "email4@gmail.com", "Qq12345678qQ", "Patronymic 4", "+375 (29) 444-44-44", "Position 2", "Surname 4" },
                    { new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"), "City 3", "Country 3", new DateTime(2004, 6, 14, 20, 5, 39, 989, DateTimeKind.Local).AddTicks(6007), "Specialist", "email3@gmail.com", 1, "Name 3", "email3@gmail.com", "Qq12345678qQ", "Patronymic 3", "+375 (29) 333-33-33", "Position 1", "Surname 3" }
                });
        }
    }
}
