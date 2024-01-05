using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechCareerWebApiTutorial.Migrations
{
    public partial class CompanyTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "CompanyRoom",
                columns: table => new
                {
                    CompaniesId = table.Column<int>(type: "int", nullable: false),
                    RoomsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRoom", x => new { x.CompaniesId, x.RoomsId });
                    table.ForeignKey(
                        name: "FK_CompanyRoom_Companies_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyRoom_Rooms_RoomsId",
                        column: x => x.RoomsId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRoom_RoomsId",
                table: "CompanyRoom",
                column: "RoomsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyRoom");

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
    }
}
