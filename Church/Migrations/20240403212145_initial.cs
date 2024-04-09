using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Church.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceTexts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "CreatedAt", "ExperienceTexts", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 3, 17, 21, 44, 521, DateTimeKind.Local).AddTicks(8337), "The people are very welcoming and nice.", "Tedd" },
                    { 2, new DateTime(2024, 4, 3, 17, 21, 44, 521, DateTimeKind.Local).AddTicks(8389), "I feel the present of God in this church.", "Mike" },
                    { 3, new DateTime(2024, 4, 3, 17, 21, 44, 521, DateTimeKind.Local).AddTicks(8394), "Worship team are so so good.", "John" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiences");
        }
    }
}
