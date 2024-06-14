using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IIS.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReviewSeedAndDeleteModeUpdation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("b223cbcc-d2b7-4b27-97eb-1a5b2c09acd1"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("fb7221d0-35e3-4e52-a6cf-3a5f6b1611d5"));

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Reviews",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CaseId", "Date", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("03b061d4-2aca-44c8-8489-c92390e21cd5"), null, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is review 3", new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e") },
                    { new Guid("16a79d25-a4f4-4cf0-99ec-835073f0c946"), null, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is review 2", new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e") },
                    { new Guid("36f010ed-8c38-4eeb-b9ec-5fb86ccf3189"), null, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is review 1", new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e") }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("03b061d4-2aca-44c8-8489-c92390e21cd5"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("16a79d25-a4f4-4cf0-99ec-835073f0c946"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("36f010ed-8c38-4eeb-b9ec-5fb86ccf3189"));

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

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "Reviews",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Serveces",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("b223cbcc-d2b7-4b27-97eb-1a5b2c09acd1"), 3, 109m, "description 2", "service 2" },
                    { new Guid("fb7221d0-35e3-4e52-a6cf-3a5f6b1611d5"), 5, 159m, "description 1", "service 1" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 13, 15, 3, 6, 547, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 13, 15, 3, 6, 547, DateTimeKind.Local).AddTicks(6701));
        }
    }
}
