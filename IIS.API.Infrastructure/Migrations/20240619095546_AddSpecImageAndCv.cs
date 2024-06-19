using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IIS.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSpecImageAndCv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("15f3e783-7728-46d3-9702-85657452c53d"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("40821a05-b130-46b9-ba71-085af5aa3220"));

            migrationBuilder.AddColumn<string>(
                name: "CvUri",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUri",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 19, 9, 55, 45, 968, DateTimeKind.Utc).AddTicks(8159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 18, 20, 15, 46, 707, DateTimeKind.Utc).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "Date",
                value: new DateTime(2024, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "Date",
                value: new DateTime(2024, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.InsertData(
                table: "Cases",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "EndDate", "ImagesUri", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("15f010ed-8c38-4eeb-b9ec-5fb36ccf3189"), 2, 500m, "Description 3", new DateTime(2024, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(7165), "[]", "Name 3", new DateTime(2024, 5, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(7165) },
                    { new Guid("36f010ed-8c38-4eeb-b9ec-5fb56ccf3189"), 5, 1400m, "Description 1", new DateTime(2024, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(7160), "[]", "Name 1", new DateTime(2024, 1, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(7156) },
                    { new Guid("36f056ed-8c38-4eeb-b9ec-5fb56ccf3189"), 8, 3500m, "Description 2", new DateTime(2024, 4, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(7163), "[]", "Name 2", new DateTime(2023, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(7162) }
                });

            migrationBuilder.InsertData(
                table: "Serveces",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("49ba3784-8ec8-426b-96b4-1f94bfdd5931"), 3, 109m, "description 2", "service 2" },
                    { new Guid("c43a31be-bfd7-4753-b9e7-9a4194c9ff50"), 5, 159m, "description 1", "service 1" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45bf8340-f203-46de-ac5f-5a7f59f2103e"),
                columns: new[] { "CvUri", "DateOfBirth", "ImageUri" },
                values: new object[] { null, new DateTime(1974, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(8945), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"),
                columns: new[] { "CvUri", "DateOfBirth", "ImageUri" },
                values: new object[] { null, new DateTime(2004, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(8941), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(5458));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("15f010ed-8c38-4eeb-b9ec-5fb36ccf3189"));

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("36f010ed-8c38-4eeb-b9ec-5fb56ccf3189"));

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("36f056ed-8c38-4eeb-b9ec-5fb56ccf3189"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("49ba3784-8ec8-426b-96b4-1f94bfdd5931"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("c43a31be-bfd7-4753-b9e7-9a4194c9ff50"));

            migrationBuilder.DropColumn(
                name: "CvUri",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ImageUri",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 18, 20, 15, 46, 707, DateTimeKind.Utc).AddTicks(2098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 19, 9, 55, 45, 968, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "Date",
                value: new DateTime(2024, 6, 18, 23, 15, 46, 707, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "Date",
                value: new DateTime(2024, 6, 18, 23, 15, 46, 707, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.InsertData(
                table: "Serveces",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("15f3e783-7728-46d3-9702-85657452c53d"), 5, 159m, "description 1", "service 1" },
                    { new Guid("40821a05-b130-46b9-ba71-085af5aa3220"), 3, 109m, "description 2", "service 2" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45bf8340-f203-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 18, 23, 15, 46, 707, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 18, 23, 15, 46, 707, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 18, 23, 15, 46, 706, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 18, 23, 15, 46, 706, DateTimeKind.Local).AddTicks(9198));
        }
    }
}
