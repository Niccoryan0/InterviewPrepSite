using InterviewPrepApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepApp.Data
{
    public class QuestionsDbContext : IdentityDbContext<ApplicationUser>
    {
        public QuestionsDbContext(DbContextOptions<QuestionsDbContext> options) : base(options)
        {
        }

        public DbSet<TechnicalQ> TechnicalQs { get; set; }
        public DbSet<BehavioralQ> BehavioralQs { get; set; }
        public DbSet<WhiteboardQ> WhiteboardQs { get; set; }
        public DbSet<TraversalQ> Traversals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region TechQSeeding
            builder.Entity<TechnicalQ>().HasData(
                new TechnicalQ
                {
                    Id = 1,
                    Question = "What is Object Oriented Programming?",
                    Answer = "Programming languages that attempt to simulate the behavior of real world objects using objects and classes.",
                    Category = "General"

                },
                new TechnicalQ
                {
                    Id = 2,
                    Question = "What are the 4 OOP Principles?",
                    Answer = "Inheritance, Abstraction, Polymorphism, and Encapsulation",
                    Category = "OOP"
                },
                new TechnicalQ
                {
                    Id = 3,
                    Question = "What is Abstraction?",
                    Answer = "The concept of reducing an object to it's most essential, logical functions and properties.",
                    Category = "OOP"
                },
                new TechnicalQ
                {
                    Id = 4,
                    Question = "What is Inheritance?",
                    Answer = "Process of generating logical hierarchies allowing \"parent\" objects to pass properties on to their \"children\".",
                    Category = "OOP"
                },
                new TechnicalQ
                {
                    Id = 5,
                    Question = "What is Encapsulation?",
                    Answer = "Separating the different components of a program to ensure clean, robust functioning overall",
                    Category = "OOP"
                },
                new TechnicalQ
                {
                    Id = 6,
                    Question = "What is Polymorphism?",
                    Answer = "Literally means \"many forms\", the concept that inherited methods and properties can be modified or changed by the children inheriting them.",
                    Category = "OOP"
                },
                new TechnicalQ
                {
                    Id = 7,
                    Question = "What does REST stand for? What is it? What data format does it usually come in?",
                    Answer = "REpresentational State Transfer, an architectural style for creating Web services that uses JSON.",
                    Category = "APIs"

                },
                new TechnicalQ
                {
                    Id = 8,
                    Question = "What tools do you know of for testing API routes?",
                    Answer = "Postman and Swagger (Many answers possible)",
                    Category = "APIs"
                },
                new TechnicalQ
                {
                    Id = 9,
                    Question = "When starting a project from scratch, do you first plan the database or the code? How might you plan a database?",
                    Answer = "Database first is a good way to go, creating an ERD to visual the database layout is a good start. Many answers possible.",
                    Category = "Process"
                },
                new TechnicalQ
                {
                    Id = 10,
                    Question = "When presented with a bug or an error in your code, what is the first thing you should do?",
                    Answer = "Debug in Visual Studio if you can locate the error using the built in tools, when going to the internet go to documentation first, then other results if that doesn't work out.",
                    Category = "Process"
                },
                new TechnicalQ
                {
                    Id = 11,
                    Question = "How do we document code?",
                    Answer = "A README for inital explanation and navigation, Summary comments for all methods to which they are applicable, and inner comments for lines or blocks of code that are not easily understood by looking at the line or the summary comment.",
                    Category = "Process"
                },
                new TechnicalQ
                {
                    Id = 12,
                    Question = "What is a generic?",
                    Answer = "Generics are a class which allows developers to define classes and methods using a placeholder, and to specify types only on instantiation.",
                    Category = "General"
                },
                new TechnicalQ
                {
                    Id = 13,
                    Question = "What is a delegate?",
                    Answer = "A delegate is a type that represents references to methods with a particular parameter list and return type.",
                    Category = "General"
                },
                new TechnicalQ
                {
                    Id = 14,
                    Question = "Why do we need tests?",
                    Answer = "The purpose is to validate that each unit of the software performs as designed. Tests allow us to ensure that each piece of an app is running correctly on it's own, allow problems to be caught faster among many other benefits.",
                    Category = "Process"
                },
                new TechnicalQ
                {
                    Id = 15,
                    Question = "What is an abstract method? Why/when are they useful?",
                    Answer = "A method without a body in a parent class. They can provide a framework for what methods their children will need to override before instantiating them.",
                    Category = "General"
                },
                new TechnicalQ
                {
                    Id = 16,
                    Question = "Can abstract classes have constructors in C#?",
                    Answer = "No",
                    Category = "OOP"
                },
                new TechnicalQ
                {
                    Id = 17,
                    Question = "When should you use Abstract classes in C#?",
                    Answer = "Abstract classes are useful when you want to provide implementation details to the children of an inherited class.",
                    Category = "OOP"
                },
                new TechnicalQ
                {
                    Id = 18,
                    Question = "Does C# support multiple lines of inheritance?",
                    Answer = "No, but it does have Interfaces.",
                    Category = "OOP"
                },
                new TechnicalQ
                {
                    Id = 19,
                    Question = "What is the difference between overloading and overriding a method?",
                    Answer = "Overloading a method means defining two methods with the same name that take in different parameters. Overriding a method means changing the behavior of an inherited method in the child class.",
                    Category = "General"
                },
                new TechnicalQ
                {
                    Id = 20,
                    Question = "What is the difference between an abstract class and an interface?",
                    Answer = "An abstract class allows you to create functionality that subclasses can implement or override. An interface only allows you to define functionality, not implement it. And whereas a class can extend only one abstract class, it can take advantage of multiple interfaces. ",
                    Category = "General"
                },
                new TechnicalQ
                {
                    Id = 21,
                    Question = "What are the 2 different data types in C#? Explain the differences (Where do they live?).",
                    Answer = "Value and Reference. Value types contain memory allocated on the stack, reference types contain addresses to items stored in the heap.",
                    Category = "General"
                },
                new TechnicalQ
                {
                    Id = 22,
                    Question = "What is LINQ? Give some examples of LINQ.",
                    Answer = "Language INtegrated Query, a uniform query syntax used to retrieve data from different sources and formats. Some examples are .Select, .Where and .Find",
                    Category = "General"
                }
            );
            #endregion

            #region BehavioralQSeeding
            builder.Entity<BehavioralQ>().HasData(
                new BehavioralQ
                {
                    Id = 1,
                    Question = "Tell me about a time you had to work on several projects at once. How did you handle that?",
                },  
                new BehavioralQ
                {
                    Id = 2,
                    Question = "How would you describe yourself in one word?",
                },  
                new BehavioralQ
                {
                    Id = 3,
                    Question = "Tell me one strength, and one weakness of yours?",
                },  
                new BehavioralQ
                {
                    Id = 4,
                    Question = "What can you offer us that someone else can not?",
                },  
                new BehavioralQ
                {
                    Id = 5,
                    Question = "What’s the one thing your former manager would like you to improve on?",
                },  
                new BehavioralQ
                {
                    Id = 6,
                    Question = "Tell me about an accomplishment you are most proud of.",
                },  
                new BehavioralQ
                {
                    Id = 7,
                    Question = "Give a time when you went above and beyond the requirements for a project.",
                },  
                new BehavioralQ
                {
                    Id = 8,
                    Question = "Tell me about a time that you disagreed with a rule or approach.",
                },  
                new BehavioralQ
                {
                    Id = 9,
                    Question = "Tell me about a time you stepped up and lead with an idea you had?",
                },  
                new BehavioralQ
                {
                    Id = 10,
                    Question = "What kind of boss and coworkers have you had the most and least success with, and why?",
                },  
                new BehavioralQ
                {
                    Id = 11,
                    Question = "Can you give us a reason someone may not like working with you?",
                },  
                new BehavioralQ
                {
                    Id = 12,
                    Question = "Tell me about a team project when you had to work with someone difficult.",
                },  
                new BehavioralQ
                {
                    Id = 13,
                    Question = "Why do you want to leave your current job?",
                },  
                new BehavioralQ
                {
                    Id = 14,
                    Question = "Why was there a gap in your employment between [insert date] and [insert date]?",
                },  
                new BehavioralQ
                {
                    Id = 15,
                    Question = "What do you like the most about working in this industry?",
                },  
                new BehavioralQ
                {
                    Id = 16,
                    Question = "Tell me how you handled a difficult situation.",
                },  
                new BehavioralQ
                {
                    Id = 17,
                    Question = "Tell me about a time you made a mistake.",
                },  
                new BehavioralQ
                {
                    Id = 18,
                    Question = "What would you look to accomplish in the first 30 days/60 days/90 days on the job?",
                },  
                new BehavioralQ
                {
                    Id = 19,
                    Question = "What do you like the most and least about working in this industry?",
                },  
                new BehavioralQ
                {
                    Id = 20,
                    Question = "Where do you see yourself in five years? Ten years?",
                },  
                new BehavioralQ
                {
                    Id = 21,
                    Question = "What is your dream job?",
                },  
                new BehavioralQ
                {
                    Id = 22,
                    Question = "Why are you looking for a new job?",
                },  
                new BehavioralQ
                {
                    Id = 23,
                    Question = "Why do you want to work here?",
                },  
                new BehavioralQ
                {
                    Id = 24,
                    Question = "What motivates/gets you up in the morning?",
                },  
                new BehavioralQ
                {
                    Id = 25,
                    Question = "Tell me about your educational background.",
                },  
                new BehavioralQ
                {
                    Id = 26,
                    Question = "How did you hear about this position?",
                },  
                new BehavioralQ
                {
                    Id = 27,
                    Question = "What are your salary requirements?",
                }
            );
            #endregion

            #region WhiteboardQSeeding
            builder.Entity<WhiteboardQ>().HasData(
                new WhiteboardQ 
                { 
                    Id = 1,
                    Question = @"Assuming the following basic  table structure
Documents(DocID, DocDate)
Keywords(KeyWordID, KeyWord)
DocumentKeywords(DocID, KeywordID)

Write a query to return the following:
Part 1: Documents with a DocDate after 4 / 1 / 1995
Part 2: Documents that contain the keyword 'Blue'
Part 3: Documents that contain either the keyword 'Blue' or 'Yellow'
Part 4: Documents that contain both the keywords 'Blue' and 'Yellow'"
                },
                new WhiteboardQ
                {
                    Id = 2,
                    Question = "Write a function to reverse a singly linked list."
                },
                new WhiteboardQ
                {
                    Id = 3,
                    Question = "Given a binary tree, find the depth of the binary tree."
                },
                new WhiteboardQ
                {
                    Id = 4,
                    Question = "Write a procedure for binary searching an array of integers."
                },
                new WhiteboardQ
                {
                    Id = 5,
                    Question = "Write me a function to generate/print/store the first n prime numbers."
                },
                new WhiteboardQ
                {
                    Id = 6,
                    Question = "Write a query to get all of the customers in a database, and their phone numbers, for the ones with the last name 'Smith'"
                },
                new WhiteboardQ
                {
                    Id = 7,
                    Question = "Given a number n, output the total number of (unique) binary trees that have n nodes."
                },
                new WhiteboardQ
                {
                    Id = 8,
                    Question = "Calculate the nth number in the Fibonacci sequence. Try to do this with a storage complexity of O(1)."
                },
                new WhiteboardQ
                {
                    Id = 9,
                    Question = "Reverse an array of integers in place."
                },
                new WhiteboardQ
                {
                    Id = 10,
                    Question = "Traverse a binary search tree and return a given value n."
                },
                new WhiteboardQ
                {
                    Id = 11,
                    Question = "Find a value in a doubly-linked list and move it to the front of the list."
                },
                new WhiteboardQ
                {
                    Id = 12,
                    Question = "Write a SQL query yielding the names of customers with at least 2 orders."
                },
                new WhiteboardQ
                {
                    Id = 13,
                    Question = "Write algorithms for doing both a depth and breadth first traversal of a binary tree. Discuss the differences in the two."
                },
                new WhiteboardQ
                {
                    Id = 14,
                    Question = "Traverse a binary tree without using recursion."
                }
            );
            #endregion

            builder.Entity<TraversalQ>().HasData(
                new TechnicalQ
                {
                    Id = 1,
                    Question = "Traverse a linked list, return max value: Iteratively",
                    Category = "Linked Lists"
                }, 
                new TechnicalQ
                {
                    Id = 2,
                    Question = "Traverse a linked list, return max value: Recursively",
                    Category = "Linked Lists"
                }, 
                new TechnicalQ
                {
                    Id = 3,
                    Question = "Traverse a binary tree, find a value n: Iteratively",
                    Category = "Trees"
                }, 
                new TechnicalQ
                {
                    Id = 4,
                    Question = "Traverse a binary tree, return the minimum value: Recursively",
                    Category = "Trees"
                },
                new TechnicalQ
                {
                    Id = 5,
                    Question = "Traverse a binary tree and return all duplicates: Breadth-first",
                    Category = "Trees"
                },
                new TechnicalQ
                {
                    Id = 6,
                    Question = "Traverse a binary search tree to find a given value n",
                    Category = "Trees"
                }, 
                new TechnicalQ
                {
                    Id = 7,
                    Question = "Reverse a given stack: Iteratively",
                    Category = "Stacks and Queues"
                }, 
                new TechnicalQ
                {
                    Id = 8,
                    Question = "Traverse a stack for a given value n: Iteratively",
                    Category = "Stacks and Queues"
                }, 
                new TechnicalQ
                {
                    Id = 9,
                    Question = "Find the maximum value in an array: Iteratively",
                    Category = "Arrays"
                }, 
                new TechnicalQ
                {
                    Id = 10,
                    Question = "Return all duplicates in a Binary Tree: Iteratively.",
                    Category = "Trees"
                }, 
                new TechnicalQ
                {
                    Id = 11,
                    Question = "Return the maximum value in a Binary Tree: Recursively.",
                    Category = "Trees"
                }, 
                new TechnicalQ
                {
                    Id = 12,
                    Question = "Remove all duplicates from a Linked List: Recursively.",
                    Category = "Linked Lists"
                }, 
                new TechnicalQ
                {
                    Id = 13,
                    Question = "Sort all values in a Queue: Iteratively.",
                    Category = "Stacks and Queues"
                }, 
                new TechnicalQ
                {
                    Id = 14,
                    Question = "Sort all values in a Stack: Recursively.",
                    Category = "Stacks and Queues"
                }
            );
        }
    }
}
