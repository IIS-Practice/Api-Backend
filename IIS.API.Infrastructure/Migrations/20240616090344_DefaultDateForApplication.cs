using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IIS.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DefaultDateForApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("0d0a0af4-b852-4f12-bc4c-c827d264a53b"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("2e8b35c1-20cc-41c1-8665-447f404467f8"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 12, 3, 43, 800, DateTimeKind.Local).AddTicks(9964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "Date",
                value: new DateTime(2024, 6, 16, 12, 3, 43, 801, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "Date",
                value: new DateTime(2024, 6, 16, 12, 3, 43, 801, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.InsertData(
                table: "Serveces",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("e6de481b-aeaa-4911-940c-770b1b728b90"), 3, 109m, "description 2", "service 2" },
                    { new Guid("ebad6638-35ac-4ff6-a1fd-5f8ecab9ef8c"), 5, 159m, "description 1", "service 1" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 16, 12, 3, 43, 794, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 16, 12, 3, 43, 794, DateTimeKind.Local).AddTicks(7576));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("e6de481b-aeaa-4911-940c-770b1b728b90"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("ebad6638-35ac-4ff6-a1fd-5f8ecab9ef8c"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 12, 3, 43, 800, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "Date",
                value: new DateTime(2024, 6, 15, 16, 46, 35, 417, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "Date",
                value: new DateTime(2024, 6, 15, 16, 46, 35, 417, DateTimeKind.Local).AddTicks(3086));

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
    }
}
