using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IIS.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DataForSpecialists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("49ba3784-8ec8-426b-96b4-1f94bfdd5931"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("c43a31be-bfd7-4753-b9e7-9a4194c9ff50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45bf8340-f203-46de-ac5f-5a7f59f2103e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 23, 12, 27, 29, 741, DateTimeKind.Utc).AddTicks(6378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 19, 9, 55, 45, 968, DateTimeKind.Utc).AddTicks(8159));

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
                keyValue: new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"),
                columns: new[] { "City", "Country", "CvUri", "DateOfBirth", "Description", "Email", "ImageUri", "Name", "NormalizedEmail", "Password", "Patronymic", "PhoneNumber", "Position", "Surname" },
                values: new object[] { "Аттава", "Канада", "", new DateTime(1964, 9, 2, 22, 20, 25, 988, DateTimeKind.Local), "Я Киану Ривз, дитя EPAMа занимаюсь разработкой 25 лет", "kiany@gmail.com", "", "Киану", "Kiany@gmail.com", "Kiany123", "Чарьзович", "+375 (29) 111-22-33", "Разработчик", "Ривз" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 23, 15, 27, 29, 741, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 23, 15, 27, 29, 741, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "CvUri", "DateOfBirth", "Description", "Discriminator", "Email", "Gender", "ImageUri", "Name", "NormalizedEmail", "Password", "Patronymic", "PhoneNumber", "Position", "Surname" },
                values: new object[,]
                {
                    { new Guid("1b6cfca3-96cf-4d5f-a1d4-12b8a00e8f7b"), "Брауард", "США", "", new DateTime(1998, 1, 23, 21, 20, 25, 988, DateTimeKind.Local), "Стажер, клянусь своей жизнью, что сделаю вам офигительного бота", "Specialist", "jahseh@gmail.com", 1, "", "Джасей", "jahseh@gmail.com", "Jahseh123", "Рикардо", "+375 (29) 111-22-34", "Разработчик", "Дуэйн" },
                    { new Guid("6a422a99-b975-485f-a95e-c1449a4d3622"), "Ленинград", "Россия", "", new DateTime(1991, 11, 5, 21, 20, 25, 988, DateTimeKind.Local), "Думаете как старший аналитик я не смогу справиться с вашим заказом? Да я даже в президенты баллотировалась", "Specialist", "Ksenia@gmail.com", 2, "", "Ксения", "ksenia@gmail.com", "Ksenia2345", "Анатольевна", "+375 (44) 947-83-63", "Бизнес-аналитик", "Собчак" },
                    { new Guid("6d028d9d-9378-4db4-8d87-35b7f3d8d973"), "Мистик-Фоллс", "США", "", new DateTime(1993, 10, 31, 21, 20, 25, 988, DateTimeKind.Local), "Если вам не понравится, наведу порчу на понос))", "Specialist", "bonbon@gmail.com", 2, "", "Бонни", "bonbon@gmail.com", "Bon12345", "Ведьмовна", "+375 (33) 666-66-66", "Разработчик", "Беннет" },
                    { new Guid("ae41a12f-3c43-4a6e-b1b1-5452e676ed98"), "Пикалево", "Россия", "", new DateTime(1973, 9, 7, 22, 20, 25, 988, DateTimeKind.Local), "Старший дизайнер, стаж 20 лет. Сделаю живой дизайн", "Specialist", "michail@gmail.com", 1, "", "Михаил", "michail@gmail.com", "Michail1", "Юрьевич", "+375 (29) 777-77-77", "Дизайнер", "Горшенёв" },
                    { new Guid("bd50b4c5-98ab-4d2b-974d-07e53c3cb627"), "Лейпциг", "ГДР", "", new DateTime(1989, 9, 1, 22, 20, 25, 988, DateTimeKind.Local), "Коллаборацию с McDonald's сделал и дизайн в figma сделаю", "Specialist", "bill@gmail.com", 1, "", "Билл", "bill@gmail.com", "Bill1234", "Симонович", "+375 (29) 111-22-45", "Дизайнер", "Каулиц" },
                    { new Guid("cdff6b4b-4a2a-4927-b9e5-80154f893539"), "Краснодар", "Россия", "", new DateTime(1995, 7, 25, 22, 20, 25, 988, DateTimeKind.Local), "Проект будет готов к 32 числу месяца", "Specialist", "Olesya@gmail.com", 2, "", "Олеся", "olesya@gmail.com", "Olesya2345", "Игоревна", "+375 (44) 375-73-96", "Разработчик", "Иванченко" },
                    { new Guid("e8b52180-e2e0-4461-9bf3-372d19d5f28c"), "Сан-Фернандо", "США", "", new DateTime(2003, 11, 1, 21, 20, 25, 988, DateTimeKind.Local), "Могу отмудохать вам дизайн или лицо. Стаж 2 года", "Specialist", "eli@gmail.com", 1, "", "Илай", "eli@gmail.com", "Eli12345", "Ястребович", "+375 (29) 111-33-11", "Дизайнер", "Московиц" },
                    { new Guid("f39abfe8-786f-4b3a-8d86-4d684e729aa6"), "Тобольск", "Россия", "", new DateTime(2000, 5, 11, 22, 20, 25, 988, DateTimeKind.Local), "За деньги да, мечу на главного бизнес-аналитика", "Specialist", "darya@gmail.com", 2, "", "Дарья", "darya@gmail.com", "Darya123", "Евгеньевна", "+375 (29) 111-22-44", "Аналитик", "Зотеева" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("5a7646e0-fc3f-4d0b-85e1-f0b567606991"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("6b4e424a-4da1-4f64-b76e-3ed51983296e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b6cfca3-96cf-4d5f-a1d4-12b8a00e8f7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a422a99-b975-485f-a95e-c1449a4d3622"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d028d9d-9378-4db4-8d87-35b7f3d8d973"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae41a12f-3c43-4a6e-b1b1-5452e676ed98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd50b4c5-98ab-4d2b-974d-07e53c3cb627"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdff6b4b-4a2a-4927-b9e5-80154f893539"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8b52180-e2e0-4461-9bf3-372d19d5f28c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f39abfe8-786f-4b3a-8d86-4d684e729aa6"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 19, 9, 55, 45, 968, DateTimeKind.Utc).AddTicks(8159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 23, 12, 27, 29, 741, DateTimeKind.Utc).AddTicks(6378));

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

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("15f010ed-8c38-4eeb-b9ec-5fb36ccf3189"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(7165), new DateTime(2024, 5, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("36f010ed-8c38-4eeb-b9ec-5fb56ccf3189"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 1, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: new Guid("36f056ed-8c38-4eeb-b9ec-5fb56ccf3189"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(7163), new DateTime(2023, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(7162) });

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
                keyValue: new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"),
                columns: new[] { "City", "Country", "CvUri", "DateOfBirth", "Description", "Email", "ImageUri", "Name", "NormalizedEmail", "Password", "Patronymic", "PhoneNumber", "Position", "Surname" },
                values: new object[] { "City 3", "Country 3", null, new DateTime(2004, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(8941), "", "email3@gmail.com", null, "Name 3", "email3@gmail.com", "Qq12345678qQ", "Patronymic 3", "+375 (29) 333-33-33", "Position 1", "Surname 3" });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "CvUri", "DateOfBirth", "Description", "Discriminator", "Email", "Gender", "ImageUri", "Name", "NormalizedEmail", "Password", "Patronymic", "PhoneNumber", "Position", "Surname" },
                values: new object[] { new Guid("45bf8340-f203-46de-ac5f-5a7f59f2103e"), "City 4", "Country 4", null, new DateTime(1974, 6, 19, 12, 55, 45, 968, DateTimeKind.Local).AddTicks(8945), "", "Specialist", "email4@gmail.com", 2, null, "Name 4", "email4@gmail.com", "Qq12345678qQ", "Patronymic 4", "+375 (29) 444-44-44", "Position 2", "Surname 4" });
        }
    }
}
