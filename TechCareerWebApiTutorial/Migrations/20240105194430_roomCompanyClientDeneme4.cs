using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechCareerWebApiTutorial.Migrations
{
    public partial class roomCompanyClientDeneme4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ClientRoom",
                columns: table => new
                {
                    RoomsId = table.Column<int>(type: "int", nullable: false),
                    clientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientRoom", x => new { x.RoomsId, x.clientsId });
                    table.ForeignKey(
                        name: "FK_ClientRoom_Clients_clientsId",
                        column: x => x.clientsId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientRoom_Rooms_RoomsId",
                        column: x => x.RoomsId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientRoom_clientsId",
                table: "ClientRoom",
                column: "clientsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientRoom");

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
    }
}
