using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IIS.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceCases");

            migrationBuilder.DropTable(
                name: "ServiceSpecialists");

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
                defaultValue: new DateTime(2024, 6, 16, 12, 14, 0, 331, DateTimeKind.Utc).AddTicks(8679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 12, 3, 43, 800, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.CreateTable(
                name: "CaseService",
                columns: table => new
                {
                    CasesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseService", x => new { x.CasesId, x.ServicesId });
                    table.ForeignKey(
                        name: "FK_CaseService_Cases_CasesId",
                        column: x => x.CasesId,
                        principalTable: "Cases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseService_Serveces_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Serveces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceSpecialist",
                columns: table => new
                {
                    ServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialistsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSpecialist", x => new { x.ServicesId, x.SpecialistsId });
                    table.ForeignKey(
                        name: "FK_ServiceSpecialist_Serveces_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Serveces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceSpecialist_Users_SpecialistsId",
                        column: x => x.SpecialistsId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                keyValue: new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                column: "DateOfBirth",
                value: new DateTime(2004, 6, 16, 15, 14, 0, 331, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                column: "DateOfBirth",
                value: new DateTime(1974, 6, 16, 15, 14, 0, 331, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "DateOfBirth", "Discriminator", "Email", "Gender", "Name", "NormalizedEmail", "Password", "Patronymic", "PhoneNumber", "Position", "Surname" },
                values: new object[,]
                {
                    { new Guid("45bf8340-f203-46de-ac5f-5a7f59f2103e"), "City 4", "Country 4", new DateTime(1974, 6, 16, 15, 14, 0, 331, DateTimeKind.Local).AddTicks(9454), "Specialist", "email4@gmail.com", 2, "Name 4", "email4@gmail.com", "Qq12345678qQ", "Patronymic 4", "+375 (29) 444-44-44", "Position 2", "Surname 4" },
                    { new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"), "City 3", "Country 3", new DateTime(2004, 6, 16, 15, 14, 0, 331, DateTimeKind.Local).AddTicks(9450), "Specialist", "email3@gmail.com", 1, "Name 3", "email3@gmail.com", "Qq12345678qQ", "Patronymic 3", "+375 (29) 333-33-33", "Position 1", "Surname 3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaseService_ServicesId",
                table: "CaseService",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSpecialist_SpecialistsId",
                table: "ServiceSpecialist",
                column: "SpecialistsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseService");

            migrationBuilder.DropTable(
                name: "ServiceSpecialist");

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("61797f27-487a-4f72-a18b-a1cfee931bc1"));

            migrationBuilder.DeleteData(
                table: "Serveces",
                keyColumn: "Id",
                keyValue: new Guid("aaf60a41-acfe-4a53-96b9-2e007099633e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45bf8340-f203-46de-ac5f-5a7f59f2103e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68bf8123-f170-46de-ac5f-5a7f59f2103e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 12, 3, 43, 800, DateTimeKind.Local).AddTicks(9964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 12, 14, 0, 331, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.CreateTable(
                name: "ServiceCases",
                columns: table => new
                {
                    CaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCases", x => new { x.CaseId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_ServiceCases_Cases_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Cases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceCases_Serveces_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Serveces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceSpecialists",
                columns: table => new
                {
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSpecialists", x => new { x.ServiceId, x.SpecialistId });
                    table.ForeignKey(
                        name: "FK_ServiceSpecialists_Serveces_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Serveces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceSpecialists_Users_SpecialistId",
                        column: x => x.SpecialistId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCases_ServiceId",
                table: "ServiceCases",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSpecialists_SpecialistId",
                table: "ServiceSpecialists",
                column: "SpecialistId");
        }
    }
}
