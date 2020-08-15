using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewPrepApp.Migrations
{
    public partial class BehavioralQSeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BehavioralQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Question",
                value: "Tell me about a time you had to work on several projects at once. How did you handle that?");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BehavioralQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Question",
                value: "What is Object Oriented Programming?");
        }
    }
}
