using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IIS.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DelUserInReviewAddSpecDescriptin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Cases_CaseId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_CaseId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("0e63de10-1b22-4cb7-ab3d-599c5d474660"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("d7e56f79-4ddf-4a86-b4fe-f0a59f7dd82d"));

            migrationBuilder.DropColumn(
                name: "CaseId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Reviews",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 18, 20, 15, 46, 707, DateTimeKind.Utc).AddTicks(2098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 18, 14, 42, 52, 33, DateTimeKind.Utc).AddTicks(8669));

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

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("03b061d4-2aca-44c8-8489-c92390e21cd5"),
                column: "Username",
                value: "Volodia");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("16a79d25-a4f4-4cf0-99ec-835073f0c946"),
                column: "Username",
                value: "Vasula");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("36f010ed-8c38-4eeb-b9ec-5fb86ccf3189"),
                column: "Username",
                value: "Bobik");

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
                columns: new[] { "DateOfBirth", "Description" },
                values: new object[] { new DateTime(1974, 6, 18, 23, 15, 46, 707, DateTimeKind.Local).AddTicks(3097), "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"),
                columns: new[] { "DateOfBirth", "Description" },
                values: new object[] { new DateTime(2004, 6, 18, 23, 15, 46, 707, DateTimeKind.Local).AddTicks(3092), "" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("15f3e783-7728-46d3-9702-85657452c53d"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("40821a05-b130-46b9-ba71-085af5aa3220"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Reviews");

            migrationBuilder.AddColumn<Guid>(
                name: "CaseId",
                table: "Reviews",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Reviews",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 18, 14, 42, 52, 33, DateTimeKind.Utc).AddTicks(8669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 18, 20, 15, 46, 707, DateTimeKind.Utc).AddTicks(2098));

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

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("03b061d4-2aca-44c8-8489-c92390e21cd5"),
                columns: new[] { "CaseId", "UserId" },
                values: new object[] { null, new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e") });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("16a79d25-a4f4-4cf0-99ec-835073f0c946"),
                columns: new[] { "CaseId", "UserId" },
                values: new object[] { null, new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e") });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("36f010ed-8c38-4eeb-b9ec-5fb86ccf3189"),
                columns: new[] { "CaseId", "UserId" },
                values: new object[] { null, new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e") });

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

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CaseId",
                table: "Reviews",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Cases_CaseId",
                table: "Reviews",
                column: "CaseId",
                principalTable: "Cases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
