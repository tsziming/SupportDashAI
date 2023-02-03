using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportDashAI.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class UserNameEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c09ca40f-c617-43dd-a22b-2342fae14b75",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "97d30ef9-eef0-4782-9083-d259f49edb00", "Admin@SupportDash.ai", "AQAAAAIAAYagAAAAEI8j9QyBnn4HmmNVpHleJxaNnrxnfQX+Hg6ALycHSUTZ2SELQm7KuckFOwo8URbbEQ==", "6994614a-b652-44e3-a25d-fa203ba74cdd", "admin@supportdash.ai" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c09ca40f-c617-43dd-a22b-2342fae14b75",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6629b4cc-13c2-490b-a53f-ee5ba335053e", "ADMIN", "AQAAAAIAAYagAAAAEDj+yWDPQXyzqEedmtm652Bpog1JEnb4OsFMIgBq6dTadqD+FAGH7v64bk1sD/aGgQ==", "e8a5d7d2-30a1-424f-87c3-45d2eb45b143", "admin" });
        }
    }
}
