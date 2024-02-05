using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamHoliday.Migrations
{
    /// <inheritdoc />
    public partial class SeededUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dea12856-c198-4129-b3f3-b893d8395082", 0, "afa688e0-1d51-4c3f-97d2-01566b4658e1", "admin@mail.com", false, "Petar", "Petrov", false, null, " ADMIN@MAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGLPowCKih3G/vOFQ0Mv9iksC9ilyR43Esceg1BE/KZVSffy2J3CiPajA8+AJWsRlw==", "0888888888", false, "06113815-ddf0-4377-a9e2-d82c4ac1b4a6", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");
        }
    }
}
