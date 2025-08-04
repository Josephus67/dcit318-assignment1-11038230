// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Grade Calculator ===");
            Console.WriteLine();
            
            Console.Write("Enter a numerical grade (0-100): ");
            
            if (double.TryParse(Console.ReadLine(), out double grade))
            {
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Error: Grade must be between 0 and 100.");
                }
                else
                {
                    char letterGrade;
                    
                    if (grade >= 90)
                    {
                        letterGrade = 'A';
                    }
                    else if (grade >= 80)
                    {
                        letterGrade = 'B';
                    }
                    else if (grade >= 70)
                    {
                        letterGrade = 'C';
                    }
                    else if (grade >= 60)
                    {
                        letterGrade = 'D';
                    }
                    else
                    {
                        letterGrade = 'F';
                    }
                    
                    Console.WriteLine($"Your letter grade is: {letterGrade}");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid numerical grade.");
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
