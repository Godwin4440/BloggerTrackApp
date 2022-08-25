using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloggerTrackApp.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "BlogInfo",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpInfoId",
                table: "BlogInfo",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogInfo_AuthorId",
                table: "BlogInfo",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogInfo_EmpInfoId",
                table: "BlogInfo",
                column: "EmpInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogInfo_AspNetUsers_AuthorId",
                table: "BlogInfo",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogInfo_AspNetUsers_EmpInfoId",
                table: "BlogInfo",
                column: "EmpInfoId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogInfo_AspNetUsers_AuthorId",
                table: "BlogInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogInfo_AspNetUsers_EmpInfoId",
                table: "BlogInfo");

            migrationBuilder.DropIndex(
                name: "IX_BlogInfo_AuthorId",
                table: "BlogInfo");

            migrationBuilder.DropIndex(
                name: "IX_BlogInfo_EmpInfoId",
                table: "BlogInfo");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "BlogInfo");

            migrationBuilder.DropColumn(
                name: "EmpInfoId",
                table: "BlogInfo");
        }
    }
}
