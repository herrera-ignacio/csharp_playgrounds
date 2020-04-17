using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Test Grade Book");
            Book.AddGrade(89.1);
            Book.AddGrade(90.5);
            Book.AddGrade(77.5);
            book.ShowStatistics();
          
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
