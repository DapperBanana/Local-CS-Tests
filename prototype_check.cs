
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Space Exploration Game!");
        Console.WriteLine("You are on a mission to explore a distant galaxy.");

        int distance = 0; // distance travelled

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Jump to next planet");
            Console.WriteLine("2. Refuel at space station");
            Console.WriteLine("3. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    distance += 10;
                    Console.WriteLine($"You travelled 10 light years. Total distance: {distance}");
                    break;
                case "2":
                    Console.WriteLine("Refueled at space station.");
                    break;
                case "3":
                    Console.WriteLine("Thanks for playing! Goodbye.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
