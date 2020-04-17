using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }
        static public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        static private List<double> grades;
        private string name;

        internal void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades)
            {
               lowGrade = Math.Min(number, lowGrade);
               highGrade = Math.Max(number, highGrade);
               result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"Lowest grade is {lowGrade}");
            Console.WriteLine($"Highest grade is {highGrade}");
            Console.WriteLine($"Average grade is {result}");
        }
    }
}