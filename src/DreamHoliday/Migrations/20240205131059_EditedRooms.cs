using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamHoliday.Migrations
{
    /// <inheritdoc />
    public partial class EditedRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DoubleBeds",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SingleBeds",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "DoubleBeds",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "SingleBeds",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Rooms");
        }
    }
}
