using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Church.Migrations.EventListsMigrations
{
    /// <inheritdoc />
    public partial class AddedEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventHappened = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EndTime", "EventHappened", "ImageUrl", "StartTime", "Title" },
                values: new object[,]
                {
                    { 1, "This is the description for the first upcoming event.", new DateTime(2024, 4, 19, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7694), false, "/images/event1.jpg", new DateTime(2024, 4, 18, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7581), "Upcoming Event 1" },
                    { 2, "This is the description for the second upcoming event.", new DateTime(2024, 4, 29, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7702), false, "/images/event2.jpg", new DateTime(2024, 4, 28, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7700), "Upcoming Event 2" },
                    { 3, "This is the description for the third upcoming event.", new DateTime(2024, 6, 9, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7719), false, "/images/event3.jpg", new DateTime(2024, 6, 8, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7705), "Upcoming Event 3" },
                    { 4, "This is the description for the first past event.", new DateTime(2024, 3, 30, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7724), true, "/images/event4.jpg", new DateTime(2024, 3, 29, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7722), "Past Event 1" },
                    { 5, "This is the description for the second past event.", new DateTime(2024, 3, 20, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7728), true, "/images/event5.jpg", new DateTime(2024, 3, 19, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7726), "Past Event 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
