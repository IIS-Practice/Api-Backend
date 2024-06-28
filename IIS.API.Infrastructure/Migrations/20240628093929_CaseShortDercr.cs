using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IIS.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CaseShortDercr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("6ad04c11-3270-4a84-af1d-a8b2c37985be"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("abd9cb6a-1506-4c1b-9719-42d400759934"));

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Cases",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 28, 9, 39, 27, 364, DateTimeKind.Utc).AddTicks(4111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 15, 56, 43, 151, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "Date",
                value: new DateTime(2024, 6, 28, 12, 39, 27, 364, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "Date",
                value: new DateTime(2024, 6, 28, 12, 39, 27, 364, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("15f010ed-8c38-4eeb-b9ec-5fb36ccf3189"),
                columns: new[] { "EndDate", "ShortDescription", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 28, 12, 39, 27, 364, DateTimeKind.Local).AddTicks(3086), "Des 3", new DateTime(2024, 5, 28, 12, 39, 27, 364, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("36f010ed-8c38-4eeb-b9ec-5fb56ccf3189"),
                columns: new[] { "EndDate", "ShortDescription", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 28, 12, 39, 27, 364, DateTimeKind.Local).AddTicks(3079), "Des 1", new DateTime(2024, 1, 28, 12, 39, 27, 364, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("36f056ed-8c38-4eeb-b9ec-5fb56ccf3189"),
                columns: new[] { "EndDate", "ShortDescription", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 12, 39, 27, 364, DateTimeKind.Local).AddTicks(3083), "Des 2", new DateTime(2023, 6, 28, 12, 39, 27, 364, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "Question" },
                values: new object[,]
                {
                    { new Guid("68ef8259-f170-46de-ac5f-5a7f59f2103e"), "Answer 2", "Question 2" },
                    { new Guid("68ef8340-f170-46de-ac5f-5a7f59f2103e"), "Answer 1", "Question 1" },
                    { new Guid("68ef8340-f170-79de-ac5f-5a7f53f2103e"), "Answer 3", "Question 3" }
                });

            migrationBuilder.InsertData(
                table: "Serveces",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1d4c7f21-0a12-4222-b08a-64d44ed719a4"), 5, 159m, "description 1", "service 1" },
                    { new Guid("9d0a6376-f546-4beb-94ff-66b8a5282acf"), 3, 109m, "description 2", "service 2" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b6cfca3-96cf-4d5f-a1d4-12b8a00e8f7b"),
                column: "DateOfBirth",
                value: new DateTime(1998, 1, 23, 22, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(1964, 9, 2, 23, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 28, 12, 39, 27, 364, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a422a99-b975-485f-a95e-c1449a4d3622"),
                column: "DateOfBirth",
                value: new DateTime(1991, 11, 5, 22, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d028d9d-9378-4db4-8d87-35b7f3d8d973"),
                column: "DateOfBirth",
                value: new DateTime(1993, 10, 31, 22, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae41a12f-3c43-4a6e-b1b1-5452e676ed98"),
                column: "DateOfBirth",
                value: new DateTime(1973, 9, 7, 23, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 28, 12, 39, 27, 364, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd50b4c5-98ab-4d2b-974d-07e53c3cb627"),
                column: "DateOfBirth",
                value: new DateTime(1989, 9, 1, 23, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdff6b4b-4a2a-4927-b9e5-80154f893539"),
                column: "DateOfBirth",
                value: new DateTime(1995, 7, 25, 23, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8b52180-e2e0-4461-9bf3-372d19d5f28c"),
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 1, 22, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f39abfe8-786f-4b3a-8d86-4d684e729aa6"),
                column: "DateOfBirth",
                value: new DateTime(2000, 5, 11, 23, 20, 25, 988, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("68ef8259-f170-46de-ac5f-5a7f59f2103e"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("68ef8340-f170-46de-ac5f-5a7f59f2103e"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("68ef8340-f170-79de-ac5f-5a7f53f2103e"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("1d4c7f21-0a12-4222-b08a-64d44ed719a4"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("9d0a6376-f546-4beb-94ff-66b8a5282acf"));

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Cases");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 27, 15, 56, 43, 151, DateTimeKind.Utc).AddTicks(6987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 28, 9, 39, 27, 364, DateTimeKind.Utc).AddTicks(4111));

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
                column: "DateOfBirth",
                value: new DateTime(1998, 1, 23, 21, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(1964, 9, 2, 22, 20, 25, 988, DateTimeKind.Local));

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
                column: "DateOfBirth",
                value: new DateTime(1991, 11, 5, 21, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d028d9d-9378-4db4-8d87-35b7f3d8d973"),
                column: "DateOfBirth",
                value: new DateTime(1993, 10, 31, 21, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae41a12f-3c43-4a6e-b1b1-5452e676ed98"),
                column: "DateOfBirth",
                value: new DateTime(1973, 9, 7, 22, 20, 25, 988, DateTimeKind.Local));

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
                column: "DateOfBirth",
                value: new DateTime(1989, 9, 1, 22, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdff6b4b-4a2a-4927-b9e5-80154f893539"),
                column: "DateOfBirth",
                value: new DateTime(1995, 7, 25, 22, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8b52180-e2e0-4461-9bf3-372d19d5f28c"),
                column: "DateOfBirth",
                value: new DateTime(2003, 11, 1, 21, 20, 25, 988, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f39abfe8-786f-4b3a-8d86-4d684e729aa6"),
                column: "DateOfBirth",
                value: new DateTime(2000, 5, 11, 22, 20, 25, 988, DateTimeKind.Local));
        }
    }
}
