using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechCareerWebApiTutorial.Migrations
{
    public partial class updateRoomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_RoomId",
                table: "Companies",
                column: "RoomId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Rooms_RoomId",
                table: "Companies",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Rooms_RoomId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Rooms_RoomId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_RoomId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Clients_RoomId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Clients");
        }
    }
}
