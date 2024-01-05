using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechCareerWebApiTutorial.Migrations
{
    public partial class roomCompanyClientDeneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Rooms_RoomId",
                table: "Clients");

            migrationBuilder.DropTable(
                name: "CompanyRoom");

            migrationBuilder.DropIndex(
                name: "IX_Clients_RoomId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Clients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Clients",
                type: "int",
                nullable: true);

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
                name: "IX_Clients_RoomId",
                table: "Clients",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRoom_RoomsId",
                table: "CompanyRoom",
                column: "RoomsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Rooms_RoomId",
                table: "Clients",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }
    }
}
