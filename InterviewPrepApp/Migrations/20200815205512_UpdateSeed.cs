using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewPrepApp.Migrations
{
    public partial class UpdateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TechnicalQs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Question",
                value: "What is the difference between an abstract class and an interface?");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TechnicalQs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Question",
                value: "What is the difference between an abstract method and an interface?");
        }
    }
}
