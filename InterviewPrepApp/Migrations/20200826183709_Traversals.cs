using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewPrepApp.Migrations
{
    public partial class Traversals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Traversals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traversals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Traversals",
                columns: new[] { "Id", "Category", "Question" },
                values: new object[,]
                {
                    { 1, "Linked Lists", "Traverse a linked list, return max value: Iteratively" },
                    { 2, "Linked Lists", "Traverse a linked list, return max value: Recursively" },
                    { 3, "Trees", "Traverse a binary tree, find a value n: Iteratively" },
                    { 4, "Trees", "Traverse a binary tree, return the minimum value: Recursively" },
                    { 5, "Trees", "Traverse a binary tree and return all duplicates: Breadth-first" },
                    { 6, "Trees", "Traverse a binary search tree to find a given value n" },
                    { 7, "Stacks and Queues", "Reverse a given stack: Iteratively" },
                    { 8, "Stacks and Queues", "Traverse a stack for a given value n: Iteratively" },
                    { 9, "Arrays", "Find the maximum value in an array: Iteratively" },
                    { 10, "Trees", "Return all duplicates in a Binary Tree: Iteratively." },
                    { 11, "Trees", "Return the maximum value in a Binary Tree: Recursively." },
                    { 12, "Linked Lists", "Remove all duplicates from a Linked List: Recursively." },
                    { 13, "Stacks and Queues", "Sort all values in a Queue: Iteratively." },
                    { 14, "Stacks and Queues", "Sort all values in a Stack: Recursively." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Traversals");
        }
    }
}
