using Microsoft.EntityFrameworkCore.Migrations;

namespace dt102g_projekt.Data.Migrations
{
    public partial class Connect_User_Table_To_Reservation_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_User_id",
                table: "Reservation",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_id",
                table: "Reservation"
                );
        }
    }
}
