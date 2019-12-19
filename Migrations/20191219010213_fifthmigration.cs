using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbyHub.Migrations
{
    public partial class fifthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobbys_Users_HobbyOwnerUserId",
                table: "Hobbys");

            migrationBuilder.DropIndex(
                name: "IX_Hobbys_HobbyOwnerUserId",
                table: "Hobbys");

            migrationBuilder.DropColumn(
                name: "HobbyOwnerUserId",
                table: "Hobbys");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Hobbys",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hobbys_UserId",
                table: "Hobbys",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbys_Users_UserId",
                table: "Hobbys",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobbys_Users_UserId",
                table: "Hobbys");

            migrationBuilder.DropIndex(
                name: "IX_Hobbys_UserId",
                table: "Hobbys");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Hobbys");

            migrationBuilder.AddColumn<int>(
                name: "HobbyOwnerUserId",
                table: "Hobbys",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hobbys_HobbyOwnerUserId",
                table: "Hobbys",
                column: "HobbyOwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbys_Users_HobbyOwnerUserId",
                table: "Hobbys",
                column: "HobbyOwnerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
