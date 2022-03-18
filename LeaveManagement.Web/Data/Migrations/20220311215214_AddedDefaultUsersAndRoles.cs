using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c4d04b0-3589-4572-8e62-16ee5700e11d", "f5c71119-d6d6-4418-b2e5-4357ff1a9fb4", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b1ef99a2-e4aa-4993-9b76-be7e6caa7348", "4d39f7db-d101-48f7-a65e-12696ef4fc48", null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b1ef99a2-e4aa-4993-9b76-be7e6caa7348", "8c4d04b0-3589-4572-8e62-16ee5700e11d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c4d04b0-3589-4572-8e62-16ee5700e11d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1ef99a2-e4aa-4993-9b76-be7e6caa7348", "8c4d04b0-3589-4572-8e62-16ee5700e11d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1ef99a2-e4aa-4993-9b76-be7e6caa7348");
        }
    }
}
