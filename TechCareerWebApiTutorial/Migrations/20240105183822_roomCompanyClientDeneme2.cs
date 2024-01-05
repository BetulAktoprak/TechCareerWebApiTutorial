using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechCareerWebApiTutorial.Migrations
{
    public partial class roomCompanyClientDeneme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ClientId",
                table: "Rooms",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Clients_ClientId",
                table: "Rooms",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Clients_ClientId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_ClientId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Rooms");
        }
    }
}
