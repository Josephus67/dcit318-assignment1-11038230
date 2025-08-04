// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Triangle Type Identifier ===");
            Console.WriteLine();
            
            try
            {
                Console.Write("Enter the length of side 1: ");
                double side1 = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Enter the length of side 2: ");
                double side2 = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Enter the length of side 3: ");
                double side3 = Convert.ToDouble(Console.ReadLine());
                
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    Console.WriteLine("Error: All sides must be positive numbers.");
                    return;
                }
                
                if (!IsValidTriangle(side1, side2, side3))
                {
                    Console.WriteLine("Error: The given sides cannot form a valid triangle.");
                    Console.WriteLine("(The sum of any two sides must be greater than the third side)");
                    return;
                }
                
                string triangleType = DetermineTriangleType(side1, side2, side3);
                
                Console.WriteLine($"\nTriangle sides: {side1}, {side2}, {side3}");
                Console.WriteLine($"Triangle type: {triangleType}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numerical values for all sides.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        
        static bool IsValidTriangle(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3) && 
                   (side1 + side3 > side2) && 
                   (side2 + side3 > side1);
        }
        
        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
