using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c4d04b0-3589-4572-8e62-16ee5700e11d",
                column: "ConcurrencyStamp",
                value: "203c2f08-a722-4d37-8ad6-a53d06ba4a0d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1ef99a2-e4aa-4993-9b76-be7e6caa7348",
                column: "ConcurrencyStamp",
                value: "7efbf1d0-b37b-4926-bb3e-6be89f25c562");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c4d04b0-3589-4572-8e62-16ee5700e11d",
                column: "ConcurrencyStamp",
                value: "f5c71119-d6d6-4418-b2e5-4357ff1a9fb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1ef99a2-e4aa-4993-9b76-be7e6caa7348",
                column: "ConcurrencyStamp",
                value: "4d39f7db-d101-48f7-a65e-12696ef4fc48");
        }
    }
}
