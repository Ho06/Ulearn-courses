using Microsoft.EntityFrameworkCore.Migrations;

namespace ULearn.Migrations
{
    public partial class addpro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "videoId",
                table: "CrsWhishes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CrsWhishes_videoId",
                table: "CrsWhishes",
                column: "videoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CrsWhishes_Videos_videoId",
                table: "CrsWhishes",
                column: "videoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrsWhishes_Videos_videoId",
                table: "CrsWhishes");

            migrationBuilder.DropIndex(
                name: "IX_CrsWhishes_videoId",
                table: "CrsWhishes");

            migrationBuilder.DropColumn(
                name: "videoId",
                table: "CrsWhishes");
        }
    }
}
