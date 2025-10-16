using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitHubPractice.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailtoEditPage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Memberships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 4,
                column: "Email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 5,
                column: "Email",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Memberships");
        }
    }
}
