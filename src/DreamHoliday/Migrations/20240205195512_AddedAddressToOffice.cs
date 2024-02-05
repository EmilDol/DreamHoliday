using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamHoliday.Migrations
{
    /// <inheritdoc />
    public partial class AddedAddressToOffice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Offices",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1cf979e-ed7d-45ae-a81f-710cd903932b", "AQAAAAIAAYagAAAAEHxaFN3NgD6mzhPZ7aGAk+jjPTL9QCz8TPP5esYKwfV/jvGxbNYGlxXsiMg6HTlRuQ==", "9fd0f1fe-0fbc-47ba-a382-cf5024a2a329" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Offices");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afa688e0-1d51-4c3f-97d2-01566b4658e1", "AQAAAAIAAYagAAAAEGLPowCKih3G/vOFQ0Mv9iksC9ilyR43Esceg1BE/KZVSffy2J3CiPajA8+AJWsRlw==", "06113815-ddf0-4377-a9e2-d82c4ac1b4a6" });
        }
    }
}
