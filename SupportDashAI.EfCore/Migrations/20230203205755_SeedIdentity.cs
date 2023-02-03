using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportDashAI.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class SeedIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48a3a5ea-799f-4e04-be28-1a3a2b528f5e", "48a3a5ea-799f-4e04-be28-1a3a2b528f5e", "SuperAdmin", "SUPERADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c09ca40f-c617-43dd-a22b-2342fae14b75", 0, "f0698fca-c43f-41fa-83ac-562cea96bdb8", "admin@supportdash.ai", true, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEONGdRSMNC8KaCgnT8YYDSnLRWdSAaa0B+8UzjfrxaWW8hGpH02J3KvDD8d3wfA62Q==", null, false, "01a70efa-087c-41b6-93db-a236517b9c39", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "48a3a5ea-799f-4e04-be28-1a3a2b528f5e", "c09ca40f-c617-43dd-a22b-2342fae14b75" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "48a3a5ea-799f-4e04-be28-1a3a2b528f5e", "c09ca40f-c617-43dd-a22b-2342fae14b75" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48a3a5ea-799f-4e04-be28-1a3a2b528f5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c09ca40f-c617-43dd-a22b-2342fae14b75");
        }
    }
}
