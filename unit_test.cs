
using System;

class FantasySportsManager
{
    static void Main()
    {
        Console.WriteLine("Welcome to Fantasy Sports Manager!");

        Console.Write("Enter your team name: ");
        string teamName = Console.ReadLine();

        Console.WriteLine($"Welcome, {teamName}!");

        int score = 0;

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. View player stats");
            Console.WriteLine("2. Make lineup changes");
            Console.WriteLine("3. Simulate match");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Player stats:");
                    // Display player stats
                    break;
                case 2:
                    Console.WriteLine("Making lineup changes...");
                    // Allow user to make changes to lineup
                    break;
                case 3:
                    Console.WriteLine("Simulating match...");
                    // Simulate a match and update score
                    score += new Random().Next(50, 100);
                    Console.WriteLine($"Your team scored {score} points!");
                    break;
                case 4:
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
