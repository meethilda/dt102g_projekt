using Microsoft.EntityFrameworkCore.Migrations;

namespace dt102g_projekt.Data.Migrations
{
    public partial class Add_User_Column_To_Reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Reservation",
                type: "text",
                nullable: true
                    );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userId",
                table: "Reservation"
                );
        }
    }
}
