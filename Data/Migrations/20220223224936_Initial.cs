using Microsoft.EntityFrameworkCore.Migrations;

namespace TheBlogProject.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_BlogUserId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_BlogUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_BlogUserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_AspNetUsers_BlogUserId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_BlogUserId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Posts_BlogUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_BlogUserId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogUserId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "BlogUserId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "BlogUserId",
                table: "Comments",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_BlogUserId",
                table: "Comments",
                newName: "IX_Comments_AuthorId");

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Blogs",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_AuthorId",
                table: "Tags",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorId",
                table: "Blogs",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_AuthorId",
                table: "Blogs",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AuthorId",
                table: "Comments",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_AuthorId",
                table: "Posts",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_AspNetUsers_AuthorId",
                table: "Tags",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_AuthorId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AuthorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_AuthorId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_AspNetUsers_AuthorId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_AuthorId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_AuthorId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Comments",
                newName: "BlogUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                newName: "IX_Comments_BlogUserId");

            migrationBuilder.AddColumn<string>(
                name: "BlogUserId",
                table: "Tags",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BlogUserId",
                table: "Posts",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BlogUserId",
                table: "Tags",
                column: "BlogUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_BlogUserId",
                table: "Posts",
                column: "BlogUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogUserId",
                table: "Blogs",
                column: "BlogUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_BlogUserId",
                table: "Blogs",
                column: "BlogUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_BlogUserId",
                table: "Comments",
                column: "BlogUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_BlogUserId",
                table: "Posts",
                column: "BlogUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_AspNetUsers_BlogUserId",
                table: "Tags",
                column: "BlogUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
