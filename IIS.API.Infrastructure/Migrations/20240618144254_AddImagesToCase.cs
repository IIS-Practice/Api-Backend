using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IIS.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddImagesToCase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("61797f27-487a-4f72-a18b-a1cfee931bc1"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("aaf60a41-acfe-4a53-96b9-2e007099633e"));

            migrationBuilder.AddColumn<string>(
                name: "ImagesUri",
                table: "Cases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 18, 14, 42, 52, 33, DateTimeKind.Utc).AddTicks(8669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 12, 14, 0, 331, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "Date",
                value: new DateTime(2024, 6, 18, 17, 42, 52, 33, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "Date",
                value: new DateTime(2024, 6, 18, 17, 42, 52, 33, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.InsertData(
                table: "Serveces",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0e63de10-1b22-4cb7-ab3d-599c5d474660"), 5, 159m, "description 1", "service 1" },
                    { new Guid("d7e56f79-4ddf-4a86-b4fe-f0a59f7dd82d"), 3, 109m, "description 2", "service 2" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45bf8340-f203-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 18, 17, 42, 52, 33, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 18, 17, 42, 52, 33, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 18, 17, 42, 52, 33, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 18, 17, 42, 52, 33, DateTimeKind.Local).AddTicks(2866));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("0e63de10-1b22-4cb7-ab3d-599c5d474660"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("d7e56f79-4ddf-4a86-b4fe-f0a59f7dd82d"));

            migrationBuilder.DropColumn(
                name: "ImagesUri",
                table: "Cases");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 12, 14, 0, 331, DateTimeKind.Utc).AddTicks(8679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 18, 14, 42, 52, 33, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "Date",
                value: new DateTime(2024, 6, 16, 15, 14, 0, 331, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "Date",
                value: new DateTime(2024, 6, 16, 15, 14, 0, 331, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.InsertData(
                table: "Serveces",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("61797f27-487a-4f72-a18b-a1cfee931bc1"), 5, 159m, "description 1", "service 1" },
                    { new Guid("aaf60a41-acfe-4a53-96b9-2e007099633e"), 3, 109m, "description 2", "service 2" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45bf8340-f203-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 16, 15, 14, 0, 331, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 16, 15, 14, 0, 331, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 16, 15, 14, 0, 331, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 16, 15, 14, 0, 331, DateTimeKind.Local).AddTicks(4963));
        }
    }
}
