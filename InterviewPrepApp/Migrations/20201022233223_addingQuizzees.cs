using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewPrepApp.Migrations
{
    public partial class addingQuizzees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    q1 = table.Column<string>(nullable: true),
                    q2 = table.Column<string>(nullable: true),
                    q3 = table.Column<string>(nullable: true),
                    q4 = table.Column<string>(nullable: true),
                    q5 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "q1", "q2", "q3", "q4", "q5" },
                values: new object[] { 1, "Test 1", "Test 2", "Test 3", "Test 4", "Test 5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quizzes");
        }
    }
}
