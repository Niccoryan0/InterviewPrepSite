﻿// <auto-generated />
using InterviewPrepApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InterviewPrepApp.Migrations
{
    [DbContext(typeof(QuestionsDbContext))]
    [Migration("20200815005709_BehavioralQSeedUpdate")]
    partial class BehavioralQSeedUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InterviewPrepApp.Models.BehavioralQ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BehavioralQs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Question = "Tell me about a time you had to work on several projects at once. How did you handle that?"
                        },
                        new
                        {
                            Id = 2,
                            Question = "How would you describe yourself in one word?"
                        },
                        new
                        {
                            Id = 3,
                            Question = "Tell me one strength, and one weakness of yours?"
                        },
                        new
                        {
                            Id = 4,
                            Question = "What can you offer us that someone else can not?"
                        },
                        new
                        {
                            Id = 5,
                            Question = "What’s the one thing your former manager would like you to improve on?"
                        },
                        new
                        {
                            Id = 6,
                            Question = "Tell me about an accomplishment you are most proud of."
                        },
                        new
                        {
                            Id = 7,
                            Question = "Give a time when you went above and beyond the requirements for a project."
                        },
                        new
                        {
                            Id = 8,
                            Question = "Tell me about a time that you disagreed with a rule or approach."
                        },
                        new
                        {
                            Id = 9,
                            Question = "Tell me about a time you stepped up and lead with an idea you had?"
                        },
                        new
                        {
                            Id = 10,
                            Question = "What kind of boss and coworkers have you had the most and least success with, and why?"
                        },
                        new
                        {
                            Id = 11,
                            Question = "Can you give us a reason someone may not like working with you?"
                        },
                        new
                        {
                            Id = 12,
                            Question = "Tell me about a team project when you had to work with someone difficult."
                        },
                        new
                        {
                            Id = 13,
                            Question = "Why do you want to leave your current job?"
                        },
                        new
                        {
                            Id = 14,
                            Question = "Why was there a gap in your employment between [insert date] and [insert date]?"
                        },
                        new
                        {
                            Id = 15,
                            Question = "What do you like the most about working in this industry?"
                        },
                        new
                        {
                            Id = 16,
                            Question = "Tell me how you handled a difficult situation."
                        },
                        new
                        {
                            Id = 17,
                            Question = "Tell me about a time you made a mistake."
                        },
                        new
                        {
                            Id = 18,
                            Question = "What would you look to accomplish in the first 30 days/60 days/90 days on the job?"
                        },
                        new
                        {
                            Id = 19,
                            Question = "What do you like the most and least about working in this industry?"
                        },
                        new
                        {
                            Id = 20,
                            Question = "Where do you see yourself in five years? Ten years?"
                        },
                        new
                        {
                            Id = 21,
                            Question = "What is your dream job?"
                        },
                        new
                        {
                            Id = 22,
                            Question = "Why are you looking for a new job?"
                        },
                        new
                        {
                            Id = 23,
                            Question = "Why do you want to work here?"
                        },
                        new
                        {
                            Id = 24,
                            Question = "What motivates/gets you up in the morning?"
                        },
                        new
                        {
                            Id = 25,
                            Question = "Tell me about your educational background."
                        },
                        new
                        {
                            Id = 26,
                            Question = "How did you hear about this position?"
                        },
                        new
                        {
                            Id = 27,
                            Question = "What are your salary requirements?"
                        });
                });

            modelBuilder.Entity("InterviewPrepApp.Models.TechnicalQ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TechnicalQs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "Programming languages that attempt to simulate the behavior of real world objects using objects and classes.",
                            Category = "General",
                            Question = "What is Object Oriented Programming?"
                        },
                        new
                        {
                            Id = 2,
                            Answer = "Inheritance, Abstraction, Polymorphism, and Encapsulation",
                            Category = "OOP",
                            Question = "What are the 4 OOP Principles?"
                        },
                        new
                        {
                            Id = 3,
                            Answer = "The concept of reducing an object to it's most essential, logical functions and properties.",
                            Category = "OOP",
                            Question = "What is Abstraction?"
                        },
                        new
                        {
                            Id = 4,
                            Answer = "Process of generating logical hierarchies allowing \"parent\" objects to pass properties on to their \"children\".",
                            Category = "OOP",
                            Question = "What is Inheritance?"
                        },
                        new
                        {
                            Id = 5,
                            Answer = "Separating the different components of a program to ensure clean, robust functioning overall",
                            Category = "OOP",
                            Question = "What is Encapsulation?"
                        },
                        new
                        {
                            Id = 6,
                            Answer = "Literally means \"many forms\", the concept that inherited methods and properties can be modified or changed by the children inheriting them.",
                            Category = "OOP",
                            Question = "What is Polymorphism?"
                        },
                        new
                        {
                            Id = 7,
                            Answer = "REpresentational State Transfer, an architectural style for creating Web services that uses JSON.",
                            Category = "APIs",
                            Question = "What does REST stand for? What is it? What data format does it usually come in?"
                        },
                        new
                        {
                            Id = 8,
                            Answer = "Postman and Swagger (Many answers possible)",
                            Category = "APIs",
                            Question = "What tools do you know of for testing API routes?"
                        },
                        new
                        {
                            Id = 9,
                            Answer = "Database first is a good way to go, creating an ERD to visual the database layout is a good start. Many answers possible.",
                            Category = "Process",
                            Question = "When starting a project from scratch, do you first plan the database or the code? How might you plan a database?"
                        },
                        new
                        {
                            Id = 10,
                            Answer = "Debug in Visual Studio if you can locate the error using the built in tools, when going to the internet go to documentation first, then other results if that doesn't work out.",
                            Category = "Process",
                            Question = "When presented with a bug or an error in your code, what is the first thing you should do?"
                        },
                        new
                        {
                            Id = 11,
                            Answer = "A README for inital explanation and navigation, Summary comments for all methods to which they are applicable, and inner comments for lines or blocks of code that are not easily understood by looking at the line or the summary comment.",
                            Category = "Process",
                            Question = "How do we document code?"
                        },
                        new
                        {
                            Id = 12,
                            Answer = "Generics are a class which allows developers to define classes and methods using a placeholder, and to specify types only on instantiation.",
                            Category = "General",
                            Question = "What is a generic?"
                        },
                        new
                        {
                            Id = 13,
                            Answer = "A delegate is a type that represents references to methods with a particular parameter list and return type.",
                            Category = "General",
                            Question = "What is a delegate?"
                        },
                        new
                        {
                            Id = 14,
                            Answer = "The purpose is to validate that each unit of the software performs as designed. Tests allow us to ensure that each piece of an app is running correctly on it's own, allow problems to be caught faster among many other benefits.",
                            Category = "Process",
                            Question = "Why do we need tests?"
                        },
                        new
                        {
                            Id = 15,
                            Answer = "A method without a body in a parent class. They can provide a framework for what methods their children will need to override before instantiating them.",
                            Category = "General",
                            Question = "What is an abstract method? Why/when are they useful?"
                        },
                        new
                        {
                            Id = 16,
                            Answer = "No",
                            Category = "OOP",
                            Question = "Can abstract classes have constructors in C#?"
                        },
                        new
                        {
                            Id = 17,
                            Answer = "Abstract classes are useful when you want to provide implementation details to the children of an inherited class.",
                            Category = "OOP",
                            Question = "When should you use Abstract classes in C#?"
                        },
                        new
                        {
                            Id = 18,
                            Answer = "No, but it does have Interfaces.",
                            Category = "OOP",
                            Question = "Does C# support multiple lines of inheritance?"
                        },
                        new
                        {
                            Id = 19,
                            Answer = "Overloading a method means defining two methods with the same name that take in different parameters. Overriding a method means changing the behavior of an inherited method in the child class.",
                            Category = "General",
                            Question = "What is the difference between overloading and overriding a method?"
                        },
                        new
                        {
                            Id = 20,
                            Answer = "An abstract class allows you to create functionality that subclasses can implement or override. An interface only allows you to define functionality, not implement it. And whereas a class can extend only one abstract class, it can take advantage of multiple interfaces. ",
                            Category = "General",
                            Question = "What is the difference between an abstract method and an interface?"
                        },
                        new
                        {
                            Id = 21,
                            Answer = "Value and Reference. Value types contain memory allocated on the stack, reference types contain addresses to items stored in the heap.",
                            Category = "General",
                            Question = "What are the 2 different data types in C#? Explain the differences (Where do they live?)."
                        },
                        new
                        {
                            Id = 22,
                            Answer = "Language INtegrated Query, a uniform query syntax used to retrieve data from different sources and formats. Some examples are .Select, .Where and .Find",
                            Category = "General",
                            Question = "What is LINQ? Give some examples of LINQ."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
