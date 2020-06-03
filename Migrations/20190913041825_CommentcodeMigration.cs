using Microsoft.EntityFrameworkCore.Migrations;

namespace Lybrary.Migrations
{
    public partial class CommentcodeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CommentCode",
                table: "Comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentCode",
                table: "Comments");
        }
    }
}
