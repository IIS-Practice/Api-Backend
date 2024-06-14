using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IIS.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixCaseTypeDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("83ac64e7-730a-4f33-b334-5fdde706db8b"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("93e42034-ffaf-43b8-a69a-071ddff36eb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10403a9a-1c2d-4348-ae50-1742e2584a41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31e582d6-b87d-4132-b30f-3e7a3af8cee6"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Cases",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Cases",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.InsertData(
                table: "Serveces",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("b223cbcc-d2b7-4b27-97eb-1a5b2c09acd1"), 3, 109m, "description 2", "service 2" },
                    { new Guid("fb7221d0-35e3-4e52-a6cf-3a5f6b1611d5"), 5, 159m, "description 1", "service 1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "DateOfBirth", "Discriminator", "Email", "Gender", "Name", "NormalizedEmail", "Password", "Patronymic", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"), "City 1", "Country 1", new DateTime(2004, 6, 13, 15, 3, 6, 547, DateTimeKind.Local).AddTicks(6687), "User", "email1@gmail.com", 1, "Name 1", "email1@gmail.com", "Qq12345678qQ", "Patronymic 1", "+375 (29) 111-11-11", "Surname 1" },
                    { new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"), "City 2", "Country 2", new DateTime(1974, 6, 13, 15, 3, 6, 547, DateTimeKind.Local).AddTicks(6701), "User", "email2@gmail.com", 2, "Name 2", "email2@gmail.com", "Qq12345678qQ", "Patronymic 2", "+375 (29) 222-22-22", "Surname 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("b223cbcc-d2b7-4b27-97eb-1a5b2c09acd1"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("fb7221d0-35e3-4e52-a6cf-3a5f6b1611d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"));

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "Cases",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "EndDate",
                table: "Cases",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Serveces",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("83ac64e7-730a-4f33-b334-5fdde706db8b"), 3, 109m, "description 2", "service 2" },
                    { new Guid("93e42034-ffaf-43b8-a69a-071ddff36eb7"), 5, 159m, "description 1", "service 1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "DateOfBirth", "Discriminator", "Email", "Gender", "Name", "NormalizedEmail", "Password", "Patronymic", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { new Guid("10403a9a-1c2d-4348-ae50-1742e2584a41"), "City 2", "Country 2", new DateTime(1974, 6, 13, 15, 1, 49, 879, DateTimeKind.Local).AddTicks(793), "User", "email2@gmail.com", 2, "Name 2", "email2@gmail.com", "Qq12345678qQ", "Patronymic 2", "+375 (29) 222-22-22", "Surname 2" },
                    { new Guid("31e582d6-b87d-4132-b30f-3e7a3af8cee6"), "City 1", "Country 1", new DateTime(2004, 6, 13, 15, 1, 49, 879, DateTimeKind.Local).AddTicks(777), "User", "email1@gmail.com", 1, "Name 1", "email1@gmail.com", "Qq12345678qQ", "Patronymic 1", "+375 (29) 111-11-11", "Surname 1" }
                });
        }
    }
}
