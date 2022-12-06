using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blog.Services.Migrations
{
    /// <inheritdoc />
    public partial class Addedposttocomments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Comments");
        }
    }
}
