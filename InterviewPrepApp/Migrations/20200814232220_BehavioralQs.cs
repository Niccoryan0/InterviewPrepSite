using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewPrepApp.Migrations
{
    public partial class BehavioralQs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BehavioralQs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BehavioralQs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BehavioralQs",
                columns: new[] { "Id", "Question" },
                values: new object[,]
                {
                    { 1, "What is Object Oriented Programming?" },
                    { 26, "How did you hear about this position?" },
                    { 25, "Tell me about your educational background." },
                    { 24, "What motivates/gets you up in the morning?" },
                    { 23, "Why do you want to work here?" },
                    { 22, "Why are you looking for a new job?" },
                    { 21, "What is your dream job?" },
                    { 20, "Where do you see yourself in five years? Ten years?" },
                    { 19, "What do you like the most and least about working in this industry?" },
                    { 18, "What would you look to accomplish in the first 30 days/60 days/90 days on the job?" },
                    { 17, "Tell me about a time you made a mistake." },
                    { 16, "Tell me how you handled a difficult situation." },
                    { 15, "What do you like the most about working in this industry?" },
                    { 14, "Why was there a gap in your employment between [insert date] and [insert date]?" },
                    { 13, "Why do you want to leave your current job?" },
                    { 12, "Tell me about a team project when you had to work with someone difficult." },
                    { 11, "Can you give us a reason someone may not like working with you?" },
                    { 10, "What kind of boss and coworkers have you had the most and least success with, and why?" },
                    { 9, "Tell me about a time you stepped up and lead with an idea you had?" },
                    { 8, "Tell me about a time that you disagreed with a rule or approach." },
                    { 7, "Give a time when you went above and beyond the requirements for a project." },
                    { 6, "Tell me about an accomplishment you are most proud of." },
                    { 5, "What’s the one thing your former manager would like you to improve on?" },
                    { 4, "What can you offer us that someone else can not?" },
                    { 3, "Tell me one strength, and one weakness of yours?" },
                    { 2, "How would you describe yourself in one word?" },
                    { 27, "What are your salary requirements?" }
                });

            migrationBuilder.UpdateData(
                table: "TechnicalQs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Category",
                value: "Process");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BehavioralQs");

            migrationBuilder.UpdateData(
                table: "TechnicalQs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Category",
                value: "");
        }
    }
}
