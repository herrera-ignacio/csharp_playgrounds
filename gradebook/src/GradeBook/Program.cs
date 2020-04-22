using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Test Grade Book");
            book.GradeAdded += OnGradeAdded;
            
            while(true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }

            var stats = book.GetStatistics();
          
            Console.WriteLine($"Lowest grade is {stats.Low}");
            Console.WriteLine($"Highest grade is {stats.High}");
            Console.WriteLine($"Average grade is {stats.Average}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
            
            if (args.Length > 0)
            {
                Console.WriteLine($"Nacho says Hello to you {args[0]}!");
            }
            else
            {
                Console.WriteLine("Nacho says Hello!");
            }

            static void OnGradeAdded(object sender, EventArgs e)
            {
                Console.WriteLine("Grade has been added!");
            }
        }
    }
}
