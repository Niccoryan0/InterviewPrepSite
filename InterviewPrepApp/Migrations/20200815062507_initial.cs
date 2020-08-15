using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewPrepApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BehavioralQs",
                columns: new[] { "Id", "Question" },
                values: new object[,]
                {
                    { 1, "Tell me about a time you had to work on several projects at once. How did you handle that?" },
                    { 27, "What are your salary requirements?" },
                    { 26, "How did you hear about this position?" },
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
                    { 25, "Tell me about your educational background." },
                    { 13, "Why do you want to leave your current job?" },
                    { 14, "Why was there a gap in your employment between [insert date] and [insert date]?" },
                    { 2, "How would you describe yourself in one word?" },
                    { 4, "What can you offer us that someone else can not?" },
                    { 5, "What’s the one thing your former manager would like you to improve on?" },
                    { 6, "Tell me about an accomplishment you are most proud of." },
                    { 3, "Tell me one strength, and one weakness of yours?" },
                    { 8, "Tell me about a time that you disagreed with a rule or approach." },
                    { 9, "Tell me about a time you stepped up and lead with an idea you had?" },
                    { 10, "What kind of boss and coworkers have you had the most and least success with, and why?" },
                    { 11, "Can you give us a reason someone may not like working with you?" },
                    { 12, "Tell me about a team project when you had to work with someone difficult." },
                    { 7, "Give a time when you went above and beyond the requirements for a project." }
                });

            migrationBuilder.InsertData(
                table: "TechnicalQs",
                columns: new[] { "Id", "Answer", "Category", "Question" },
                values: new object[,]
                {
                    { 20, "An abstract class allows you to create functionality that subclasses can implement or override. An interface only allows you to define functionality, not implement it. And whereas a class can extend only one abstract class, it can take advantage of multiple interfaces. ", "General", "What is the difference between an abstract method and an interface?" },
                    { 12, "Generics are a class which allows developers to define classes and methods using a placeholder, and to specify types only on instantiation.", "General", "What is a generic?" },
                    { 19, "Overloading a method means defining two methods with the same name that take in different parameters. Overriding a method means changing the behavior of an inherited method in the child class.", "General", "What is the difference between overloading and overriding a method?" },
                    { 18, "No, but it does have Interfaces.", "OOP", "Does C# support multiple lines of inheritance?" },
                    { 17, "Abstract classes are useful when you want to provide implementation details to the children of an inherited class.", "OOP", "When should you use Abstract classes in C#?" },
                    { 16, "No", "OOP", "Can abstract classes have constructors in C#?" },
                    { 15, "A method without a body in a parent class. They can provide a framework for what methods their children will need to override before instantiating them.", "General", "What is an abstract method? Why/when are they useful?" },
                    { 14, "The purpose is to validate that each unit of the software performs as designed. Tests allow us to ensure that each piece of an app is running correctly on it's own, allow problems to be caught faster among many other benefits.", "Process", "Why do we need tests?" },
                    { 13, "A delegate is a type that represents references to methods with a particular parameter list and return type.", "General", "What is a delegate?" },
                    { 11, "A README for inital explanation and navigation, Summary comments for all methods to which they are applicable, and inner comments for lines or blocks of code that are not easily understood by looking at the line or the summary comment.", "Process", "How do we document code?" },
                    { 5, "Separating the different components of a program to ensure clean, robust functioning overall", "OOP", "What is Encapsulation?" },
                    { 9, "Database first is a good way to go, creating an ERD to visual the database layout is a good start. Many answers possible.", "Process", "When starting a project from scratch, do you first plan the database or the code? How might you plan a database?" },
                    { 8, "Postman and Swagger (Many answers possible)", "APIs", "What tools do you know of for testing API routes?" },
                    { 7, "REpresentational State Transfer, an architectural style for creating Web services that uses JSON.", "APIs", "What does REST stand for? What is it? What data format does it usually come in?" },
                    { 6, "Literally means \"many forms\", the concept that inherited methods and properties can be modified or changed by the children inheriting them.", "OOP", "What is Polymorphism?" },
                    { 4, "Process of generating logical hierarchies allowing \"parent\" objects to pass properties on to their \"children\".", "OOP", "What is Inheritance?" },
                    { 3, "The concept of reducing an object to it's most essential, logical functions and properties.", "OOP", "What is Abstraction?" },
                    { 2, "Inheritance, Abstraction, Polymorphism, and Encapsulation", "OOP", "What are the 4 OOP Principles?" },
                    { 1, "Programming languages that attempt to simulate the behavior of real world objects using objects and classes.", "General", "What is Object Oriented Programming?" },
                    { 21, "Value and Reference. Value types contain memory allocated on the stack, reference types contain addresses to items stored in the heap.", "General", "What are the 2 different data types in C#? Explain the differences (Where do they live?)." },
                    { 10, "Debug in Visual Studio if you can locate the error using the built in tools, when going to the internet go to documentation first, then other results if that doesn't work out.", "Process", "When presented with a bug or an error in your code, what is the first thing you should do?" },
                    { 22, "Language INtegrated Query, a uniform query syntax used to retrieve data from different sources and formats. Some examples are .Select, .Where and .Find", "General", "What is LINQ? Give some examples of LINQ." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BehavioralQs");

            migrationBuilder.DropTable(
                name: "TechnicalQs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
