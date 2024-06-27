using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IIS.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixDataForSpec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("5a7646e0-fc3f-4d0b-85e1-f0b567606991"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("6b4e424a-4da1-4f64-b76e-3ed51983296e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 15, 56, 43, 151, DateTimeKind.Utc).AddTicks(6987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 23, 12, 27, 29, 741, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "Date",
                value: new DateTime(2024, 6, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "Date",
                value: new DateTime(2024, 6, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("15f010ed-8c38-4eeb-b9ec-5fb36ccf3189"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(6056), new DateTime(2024, 5, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("36f010ed-8c38-4eeb-b9ec-5fb56ccf3189"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(6049), new DateTime(2024, 1, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("36f056ed-8c38-4eeb-b9ec-5fb56ccf3189"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(6053), new DateTime(2023, 6, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.InsertData(
                table: "Serveces",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("6ad04c11-3270-4a84-af1d-a8b2c37985be"), 5, 159m, "description 1", "service 1" },
                    { new Guid("abd9cb6a-1506-4c1b-9719-42d400759934"), 3, 109m, "description 2", "service 2" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b6cfca3-96cf-4d5f-a1d4-12b8a00e8f7b"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a422a99-b975-485f-a95e-c1449a4d3622"),
                columns: new[] { "CvUri", "ImageUri", "Position" },
                values: new object[] { null, null, "Аналитик" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d028d9d-9378-4db4-8d87-35b7f3d8d973"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae41a12f-3c43-4a6e-b1b1-5452e676ed98"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd50b4c5-98ab-4d2b-974d-07e53c3cb627"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdff6b4b-4a2a-4927-b9e5-80154f893539"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8b52180-e2e0-4461-9bf3-372d19d5f28c"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f39abfe8-786f-4b3a-8d86-4d684e729aa6"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("6ad04c11-3270-4a84-af1d-a8b2c37985be"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("abd9cb6a-1506-4c1b-9719-42d400759934"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 23, 12, 27, 29, 741, DateTimeKind.Utc).AddTicks(6378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 15, 56, 43, 151, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "Date",
                value: new DateTime(2024, 6, 23, 15, 27, 29, 741, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "Date",
                value: new DateTime(2024, 6, 23, 15, 27, 29, 741, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("15f010ed-8c38-4eeb-b9ec-5fb36ccf3189"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 27, 29, 741, DateTimeKind.Local).AddTicks(5264), new DateTime(2024, 5, 23, 15, 27, 29, 741, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("36f010ed-8c38-4eeb-b9ec-5fb56ccf3189"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 27, 29, 741, DateTimeKind.Local).AddTicks(5254), new DateTime(2024, 1, 23, 15, 27, 29, 741, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("36f056ed-8c38-4eeb-b9ec-5fb56ccf3189"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 15, 27, 29, 741, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 6, 23, 15, 27, 29, 741, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.InsertData(
                table: "Serveces",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("5a7646e0-fc3f-4d0b-85e1-f0b567606991"), 3, 109m, "description 2", "service 2" },
                    { new Guid("6b4e424a-4da1-4f64-b76e-3ed51983296e"), 5, 159m, "description 1", "service 1" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b6cfca3-96cf-4d5f-a1d4-12b8a00e8f7b"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 23, 15, 27, 29, 741, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a422a99-b975-485f-a95e-c1449a4d3622"),
                columns: new[] { "CvUri", "ImageUri", "Position" },
                values: new object[] { "", "", "Бизнес-аналитик" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d028d9d-9378-4db4-8d87-35b7f3d8d973"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae41a12f-3c43-4a6e-b1b1-5452e676ed98"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 23, 15, 27, 29, 741, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd50b4c5-98ab-4d2b-974d-07e53c3cb627"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdff6b4b-4a2a-4927-b9e5-80154f893539"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8b52180-e2e0-4461-9bf3-372d19d5f28c"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f39abfe8-786f-4b3a-8d86-4d684e729aa6"),
                columns: new[] { "CvUri", "ImageUri" },
                values: new object[] { "", "" });
        }
    }
}
