using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class UpdatingUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "birth_year",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "photo_url",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "role",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "birth_year",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "location",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "photo_url",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Users");
        }
    }
}
