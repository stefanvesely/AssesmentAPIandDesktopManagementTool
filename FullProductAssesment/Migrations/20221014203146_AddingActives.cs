using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullProductAssesment.Migrations
{
    public partial class AddingActives : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Stores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Products");
        }
    }
}
