using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewPrepApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TechnicalQs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalQs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TechnicalQs",
                columns: new[] { "Id", "Answer", "Category", "Question" },
                values: new object[,]
                {
                    { 1, "Programming languages that attempt to simulate the behavior of real world objects using objects and classes.", "General", "What is Object Oriented Programming?" },
                    { 20, "An abstract class allows you to create functionality that subclasses can implement or override. An interface only allows you to define functionality, not implement it. And whereas a class can extend only one abstract class, it can take advantage of multiple interfaces. ", "General", "What is the difference between an abstract method and an interface?" },
                    { 19, "Overloading a method means defining two methods with the same name that take in different parameters. Overriding a method means changing the behavior of an inherited method in the child class.", "General", "What is the difference between overloading and overriding a method?" },
                    { 18, "No, but it does have Interfaces.", "OOP", "Does C# support multiple lines of inheritance?" },
                    { 17, "Abstract classes are useful when you want to provide implementation details to the children of an inherited class.", "OOP", "When should you use Abstract classes in C#?" },
                    { 16, "No", "OOP", "Can abstract classes have constructors in C#?" },
                    { 15, "A method without a body in a parent class. They can provide a framework for what methods their children will need to override before instantiating them.", "General", "What is an abstract method? Why/when are they useful?" },
                    { 14, "The purpose is to validate that each unit of the software performs as designed. Tests allow us to ensure that each piece of an app is running correctly on it's own, allow problems to be caught faster among many other benefits.", "", "Why do we need tests?" },
                    { 13, "A delegate is a type that represents references to methods with a particular parameter list and return type.", "General", "What is a delegate?" },
                    { 12, "Generics are a class which allows developers to define classes and methods using a placeholder, and to specify types only on instantiation.", "General", "What is a generic?" },
                    { 11, "A README for inital explanation and navigation, Summary comments for all methods to which they are applicable, and inner comments for lines or blocks of code that are not easily understood by looking at the line or the summary comment.", "Process", "How do we document code?" },
                    { 10, "Debug in Visual Studio if you can locate the error using the built in tools, when going to the internet go to documentation first, then other results if that doesn't work out.", "Process", "When presented with a bug or an error in your code, what is the first thing you should do?" },
                    { 9, "Database first is a good way to go, creating an ERD to visual the database layout is a good start. Many answers possible.", "Process", "When starting a project from scratch, do you first plan the database or the code? How might you plan a database?" },
                    { 8, "Postman and Swagger (Many answers possible)", "APIs", "What tools do you know of for testing API routes?" },
                    { 7, "REpresentational State Transfer, an architectural style for creating Web services that uses JSON.", "APIs", "What does REST stand for? What is it? What data format does it usually come in?" },
                    { 6, "Literally means \"many forms\", the concept that inherited methods and properties can be modified or changed by the children inheriting them.", "OOP", "What is Polymorphism?" },
                    { 5, "Separating the different components of a program to ensure clean, robust functioning overall", "OOP", "What is Encapsulation?" },
                    { 4, "Process of generating logical hierarchies allowing \"parent\" objects to pass properties on to their \"children\".", "OOP", "What is Inheritance?" },
                    { 3, "The concept of reducing an object to it's most essential, logical functions and properties.", "OOP", "What is Abstraction?" },
                    { 2, "Inheritance, Abstraction, Polymorphism, and Encapsulation", "OOP", "What are the 4 OOP Principles?" },
                    { 21, "Value and Reference. Value types contain memory allocated on the stack, reference types contain addresses to items stored in the heap.", "General", "What are the 2 different data types in C#? Explain the differences (Where do they live?)." },
                    { 22, "Language INtegrated Query, a uniform query syntax used to retrieve data from different sources and formats. Some examples are .Select, .Where and .Find", "General", "What is LINQ? Give some examples of LINQ." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TechnicalQs");
        }
    }
}
