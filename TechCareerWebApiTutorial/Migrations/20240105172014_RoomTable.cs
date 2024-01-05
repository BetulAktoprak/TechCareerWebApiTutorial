using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechCareerWebApiTutorial.Migrations
{
    public partial class RoomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_RoomId",
                table: "Clients",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Rooms_RoomId",
                table: "Clients",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Rooms_RoomId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_RoomId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Clients");
        }
    }
}
