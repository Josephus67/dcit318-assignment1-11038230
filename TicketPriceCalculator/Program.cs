// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Movie Ticket Price Calculator ===");
            Console.WriteLine();
            
            Console.Write("Enter your age: ");
            
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age < 0 || age > 150)
                {
                    Console.WriteLine("Error: Please enter a valid age.");
                }
                else
                {
                    decimal ticketPrice;
                    string category;
                    
                    if (age <= 12)
                    {
                        ticketPrice = 7.00m;
                        category = "Child";
                    }
                    else if (age >= 65)
                    {
                        ticketPrice = 7.00m;
                        category = "Senior Citizen";
                    }
                    else
                    {
                        ticketPrice = 10.00m;
                        category = "Regular";
                    }
                    
                    Console.WriteLine($"Category: {category}");
                    Console.WriteLine($"Ticket Price: GHC{ticketPrice:F2}");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid age (whole number).");
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
