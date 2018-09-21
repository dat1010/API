using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class AddingPin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "hashed_verification_pin");

            migrationBuilder.AddColumn<int>(
                name: "verification_pin_timeout",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "verification_pin_timeout",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "hashed_verification_pin",
                table: "Users",
                newName: "Password");
        }
    }
}
