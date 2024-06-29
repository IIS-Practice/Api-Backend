using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IIS.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CaseShortDescr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("15f010ed-8c38-4eeb-b9ec-5fb36ccf3189"));

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("36f056ed-8c38-4eeb-b9ec-5fb56ccf3189"));

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
                defaultValue: new DateTime(2024, 6, 29, 19, 50, 35, 349, DateTimeKind.Utc).AddTicks(2939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 27, 15, 56, 43, 151, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "Date",
                value: new DateTime(2024, 6, 29, 22, 50, 35, 349, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "Date",
                value: new DateTime(2024, 6, 29, 22, 50, 35, 349, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("36f010ed-8c38-4eeb-b9ec-5fb56ccf3189"),
                columns: new[] { "Complexity", "Cost", "Description", "EndDate", "Name", "ShortDescription", "StartDate" },
                values: new object[] { 6, 900m, "   <div class=\"case-description\" style=\"margin-top: 100px;\">\r\n          <h2 style=\"font-size: 1.75rem; font-weight: 600; line-height: 2.133rem; margin-bottom: 60px;\">\r\n            PITA STREET FOOD\r\n          </h2>\r\n          <p style=\"font-size: 1.5rem; font-weight: 400; line-height: 1.828rem; margin-bottom: 15px;\">\r\n            Специализируется на <br /> кулинарии\r\n          </p>\r\n        </div>\r\n        <div class=\"project-details-image\" style=\"display: flex; flex-direction: row; margin-bottom: 130px;\">\r\n          <img style=\"height: 37.3rem; width: 27.7rem; object-fit: cover; margin-right: 3%;\" src=\"https://avatars.mds.yandex.net/i?id=48a4918289cb9ad4a778c06b628dfd8765dc83a0-12146588-images-thumbs&n=13\" alt=\"Project Details\" />\r\n          <div class=\"info\" style=\"display: flex; justify-content: space-between; flex-direction: column;\">\r\n            <p style=\"font-size: 1.5rem; font-weight: 400; line-height: 1.828rem; text-align: left;\">\r\n              Компания “PITA STREET FOOD” обратилась к нам за разработкой полноценного сайта их заведения. В ходе живого общения с нашими специалистами, заказчик четко определился со структурой сайта, также в ТЗ была включена реализация платёжной системы сайта.\r\n            </p>\r\n            <p style=\"font-size: 1.5rem; font-weight: 400; line-height: 1.828rem; text-align: left;\">\r\n              На ранних этапах сотрудничества, мы составили поэтапную смету, промежуточные сроки реализации, в рамках которых вели дальнейшую разработку проекта.\r\n            </p>\r\n          </div>\r\n        </div>", new DateTime(2024, 6, 29, 22, 50, 35, 349, DateTimeKind.Local).AddTicks(2013), "PITA STREET FOOD", "Разработка сайта для корректного отображения на всех устройствах!", new DateTime(2024, 1, 29, 22, 50, 35, 349, DateTimeKind.Local).AddTicks(2010) });

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
                    { new Guid("8b5dbd10-01a3-4430-8a7c-37df82f47024"), 3, 109m, "description 2", "service 2" },
                    { new Guid("991e9ad5-6ed1-4337-be99-6b79b8e2c1f7"), 5, 159m, "description 1", "service 1" }
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
                value: new DateTime(2004, 6, 29, 22, 50, 35, 349, DateTimeKind.Local).AddTicks(391));

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
                value: new DateTime(1974, 6, 29, 22, 50, 35, 349, DateTimeKind.Local).AddTicks(405));

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
                keyValue: new Guid("8b5dbd10-01a3-4430-8a7c-37df82f47024"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("991e9ad5-6ed1-4337-be99-6b79b8e2c1f7"));

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
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 50, 35, 349, DateTimeKind.Utc).AddTicks(2939));

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
                keyValue: new Guid("36f010ed-8c38-4eeb-b9ec-5fb56ccf3189"),
                columns: new[] { "Complexity", "Cost", "Description", "EndDate", "Name", "StartDate" },
                values: new object[] { 5, 1400m, "Description 1", new DateTime(2024, 6, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(6049), "Name 1", new DateTime(2024, 1, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.InsertData(
                table: "Cases",
                columns: new[] { "Id", "Complexity", "Cost", "Description", "EndDate", "ImagesUri", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("15f010ed-8c38-4eeb-b9ec-5fb36ccf3189"), 2, 500m, "Description 3", new DateTime(2024, 6, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(6056), "[]", "Name 3", new DateTime(2024, 5, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(6056) },
                    { new Guid("36f056ed-8c38-4eeb-b9ec-5fb56ccf3189"), 8, 3500m, "Description 2", new DateTime(2024, 4, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(6053), "[]", "Name 2", new DateTime(2023, 6, 27, 18, 56, 43, 151, DateTimeKind.Local).AddTicks(6052) }
                });

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
