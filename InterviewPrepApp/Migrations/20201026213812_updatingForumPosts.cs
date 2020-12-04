using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewPrepApp.Migrations
{
    public partial class updatingForumPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.AddColumn<string>(
                name: "technical1a",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "technical1q",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "technical2a",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "technical2q",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "technical3a",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "technical3q",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "whiteboard1a",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "whiteboard1q",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "whiteboard2a",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "whiteboard2q",
                table: "Quizzes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "technical1a",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "technical1q",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "technical2a",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "technical2q",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "technical3a",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "technical3q",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "whiteboard1a",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "whiteboard1q",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "whiteboard2a",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "whiteboard2q",
                table: "Quizzes");

            migrationBuilder.AddColumn<string>(
                name: "technical1",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "technical2",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "technical3",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "whiteboard1",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "whiteboard2",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "Avatar", "CreatedDate", "Downvotes", "UpdatedDate", "Upvotes", "Username", "technical1", "technical2", "technical3", "whiteboard1", "whiteboard2" },
                values: new object[] { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Test 1", "Test 2", "Test 3", "Test 4", "Test 5" });
        }
    }
}
