using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Test Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();
          
            Console.WriteLine($"Lowest grade is {stats.Low}");
            Console.WriteLine($"Highest grade is {stats.High}");
            Console.WriteLine($"Average grade is {stats.Average}");
            
            if (args.Length > 0)
            {
                Console.WriteLine($"Nacho says Hello to you {args[0]}!");
            }
            else
            {
                Console.WriteLine("Nacho says Hello!");
            }
        }
    }
}
