using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupportDashAI.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class NormalizedEmailSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c09ca40f-c617-43dd-a22b-2342fae14b75",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6629b4cc-13c2-490b-a53f-ee5ba335053e", "admin@supportdash.ai", "AQAAAAIAAYagAAAAEDj+yWDPQXyzqEedmtm652Bpog1JEnb4OsFMIgBq6dTadqD+FAGH7v64bk1sD/aGgQ==", "e8a5d7d2-30a1-424f-87c3-45d2eb45b143" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c09ca40f-c617-43dd-a22b-2342fae14b75",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0698fca-c43f-41fa-83ac-562cea96bdb8", null, "AQAAAAIAAYagAAAAEONGdRSMNC8KaCgnT8YYDSnLRWdSAaa0B+8UzjfrxaWW8hGpH02J3KvDD8d3wfA62Q==", "01a70efa-087c-41b6-93db-a236517b9c39" });
        }
    }
}
