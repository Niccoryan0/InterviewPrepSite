using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewPrepApp.Migrations
{
    public partial class addingForumPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "q1",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "q2",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "q3",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "q4",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "q5",
                table: "Quizzes");

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Quizzes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Downvotes",
                table: "Quizzes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Quizzes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Upvotes",
                table: "Quizzes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "technical1",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "technical2",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "technical3",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "whiteboard1",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "whiteboard2",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ForumComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Upvotes = table.Column<int>(nullable: false),
                    Downvotes = table.Column<int>(nullable: false),
                    QuizId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumComments_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "technical1", "technical2", "technical3", "whiteboard1", "whiteboard2" },
                values: new object[] { "Test 1", "Test 2", "Test 3", "Test 4", "Test 5" });

            migrationBuilder.CreateIndex(
                name: "IX_ForumComments_QuizId",
                table: "ForumComments",
                column: "QuizId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForumComments");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Downvotes",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Upvotes",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "technical1",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "technical2",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "technical3",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "whiteboard1",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "whiteboard2",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "q1",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "q2",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "q3",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "q4",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "q5",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "q1", "q2", "q3", "q4", "q5" },
                values: new object[] { "Test 1", "Test 2", "Test 3", "Test 4", "Test 5" });
        }
    }
}
