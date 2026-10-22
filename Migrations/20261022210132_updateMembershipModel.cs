using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitHubPractice.Migrations
{
    /// <inheritdoc />
    public partial class updateMembershipModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Memberships",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: null);

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: null);

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: null);

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: null);

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Memberships");
        }
    }
}
