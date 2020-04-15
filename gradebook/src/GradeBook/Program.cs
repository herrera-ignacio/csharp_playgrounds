using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
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
