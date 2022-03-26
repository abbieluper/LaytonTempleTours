using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaytonTempleTours.Migrations
{
    public partial class initialyeet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    TimeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    SlotAvailable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.TimeId);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    SizeOfGroup = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    TimeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Times_TimeId",
                        column: x => x.TimeId,
                        principalTable: "Times",
                        principalColumn: "TimeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 66, new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 65, new DateTime(2022, 4, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 64, new DateTime(2022, 4, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 63, new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 62, new DateTime(2022, 4, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 61, new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 60, new DateTime(2022, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 59, new DateTime(2022, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 58, new DateTime(2022, 4, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 57, new DateTime(2022, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 56, new DateTime(2022, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 55, new DateTime(2022, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 54, new DateTime(2022, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 53, new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 52, new DateTime(2022, 3, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 51, new DateTime(2022, 3, 31, 19, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 50, new DateTime(2022, 3, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 49, new DateTime(2022, 3, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 48, new DateTime(2022, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 67, new DateTime(2022, 4, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 47, new DateTime(2022, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 68, new DateTime(2022, 4, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 70, new DateTime(2022, 4, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 89, new DateTime(2022, 4, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 88, new DateTime(2022, 4, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 87, new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 86, new DateTime(2022, 4, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 85, new DateTime(2022, 4, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 84, new DateTime(2022, 4, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 83, new DateTime(2022, 4, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 82, new DateTime(2022, 4, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 81, new DateTime(2022, 4, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 80, new DateTime(2022, 4, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 79, new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 78, new DateTime(2022, 4, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 77, new DateTime(2022, 4, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 76, new DateTime(2022, 4, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 75, new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 74, new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 73, new DateTime(2022, 4, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 72, new DateTime(2022, 4, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 71, new DateTime(2022, 4, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 69, new DateTime(2022, 4, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 90, new DateTime(2022, 4, 3, 19, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 46, new DateTime(2022, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 44, new DateTime(2022, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 20, new DateTime(2022, 3, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 19, new DateTime(2022, 3, 29, 13, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 18, new DateTime(2022, 3, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 17, new DateTime(2022, 3, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 16, new DateTime(2022, 3, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 15, new DateTime(2022, 3, 29, 9, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 14, new DateTime(2022, 3, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 13, new DateTime(2022, 3, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 12, new DateTime(2022, 3, 28, 19, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 11, new DateTime(2022, 3, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 10, new DateTime(2022, 3, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 9, new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 8, new DateTime(2022, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 7, new DateTime(2022, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 6, new DateTime(2022, 3, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 5, new DateTime(2022, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 4, new DateTime(2022, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 2, new DateTime(2022, 3, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 21, new DateTime(2022, 3, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 45, new DateTime(2022, 3, 31, 13, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 22, new DateTime(2022, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 24, new DateTime(2022, 3, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 43, new DateTime(2022, 3, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 42, new DateTime(2022, 3, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 41, new DateTime(2022, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 40, new DateTime(2022, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 39, new DateTime(2022, 3, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 38, new DateTime(2022, 3, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 37, new DateTime(2022, 3, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 36, new DateTime(2022, 3, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 35, new DateTime(2022, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 34, new DateTime(2022, 3, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 33, new DateTime(2022, 3, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 32, new DateTime(2022, 3, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 31, new DateTime(2022, 3, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 30, new DateTime(2022, 3, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 29, new DateTime(2022, 3, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 28, new DateTime(2022, 3, 30, 9, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 27, new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 26, new DateTime(2022, 3, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 25, new DateTime(2022, 3, 29, 19, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 23, new DateTime(2022, 3, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeId", "DateTime", "SlotAvailable" },
                values: new object[] { 91, new DateTime(2022, 4, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_TimeId",
                table: "Appointments",
                column: "TimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Times");
        }
    }
}
