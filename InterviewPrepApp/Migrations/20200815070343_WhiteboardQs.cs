using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewPrepApp.Migrations
{
    public partial class WhiteboardQs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WhiteboardQs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhiteboardQs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WhiteboardQs",
                columns: new[] { "Id", "Question" },
                values: new object[,]
                {
                    { 1, @"Assuming the following basic  table structure
                Documents(DocID, DocDate)
                Keywords(KeyWordID, KeyWord)
                DocumentKeywords(DocID, KeywordID)

                Write a query to return the following:
                Part 1: Documents with a DocDate after 4 / 1 / 1995
                Part 2: Documents that contain the keyword 'Blue'
                Part 3: Documents that contain either the keyword 'Blue' or 'Yellow'
                Part 4: Documents that contain both the keywords 'Blue' and 'Yellow'" },
                    { 2, "Write a function to reverse a singly linked list." },
                    { 3, "Given a binary tree, find the depth of the binary tree." },
                    { 4, "Write a procedure for binary searching an array of integers." },
                    { 5, "Write me a function to generate/print/store the first n prime numbers." },
                    { 6, "Write a query to get all of the customers in a database, and their phone numbers, for the ones with the last name 'Smith'" },
                    { 7, "Given a number n, output the total number of (unique) binary trees that have n nodes." },
                    { 8, "Calculate the nth number in the Fibonacci sequence. Try to do this with a storage complexity of O(1)." },
                    { 9, "Reverse an array of integers in place." },
                    { 10, "Traverse a binary search tree and return a given value n." },
                    { 11, "Find a value in a doubly-linked list and move it to the front of the list." },
                    { 12, "Write a SQL query yielding the names of customers with at least 2 orders." },
                    { 13, "Write algorithms for doing both a depth and breadth first traversal of a binary tree. Discuss the differences in the two." },
                    { 14, "Traverse a binary tree without using recursion." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WhiteboardQs");
        }
    }
}
