using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GitHubPractice.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Memberships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memberships", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "Id", "IsActive", "JoinDate", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2025, 6, 28, 20, 51, 0, 0, DateTimeKind.Unspecified), "Frank Furter" },
                    { 2, true, new DateTime(2025, 1, 28, 20, 51, 0, 0, DateTimeKind.Unspecified), "Cookie Crumb" },
                    { 3, true, new DateTime(2025, 1, 1, 20, 51, 0, 0, DateTimeKind.Unspecified), "Sierra Madre" },
                    { 4, true, new DateTime(2025, 2, 14, 20, 51, 0, 0, DateTimeKind.Unspecified), "Ima Winner" },
                    { 5, true, new DateTime(2025, 3, 7, 20, 51, 0, 0, DateTimeKind.Unspecified), "Truly Sporty" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Memberships");
        }
    }
}
