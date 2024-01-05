using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechCareerWebApiTutorial.Migrations
{
    public partial class roomCompanyClientDeneme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_CompanyId",
                table: "Rooms",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Companies_CompanyId",
                table: "Rooms",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Companies_CompanyId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_CompanyId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Rooms");
        }
    }
}
