using Microsoft.EntityFrameworkCore.Migrations;

namespace dt102g_projekt.Data.Migrations
{
    public partial class User_apartmentnumb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
    name: "ApartmentNumb", table: "AspNetUsers", nullable: false, defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
    name: "ApartmentNumb",
    table: "AspNetUsers");
        }

    }
}
