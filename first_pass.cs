
using System;

class FantasySportsManager
{
    static void Main()
    {
        Console.WriteLine("Welcome to Fantasy Sports Manager!");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Create a new team");
            Console.WriteLine("2. View team roster");
            Console.WriteLine("3. Edit team roster");
            Console.WriteLine("4. View player stats");
            Console.WriteLine("5. Quit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Creating a new team...");
                    // Add code to create a new team here
                    break;
                case 2:
                    Console.WriteLine("Viewing team roster...");
                    // Add code to display team roster here
                    break;
                case 3:
                    Console.WriteLine("Editing team roster...");
                    // Add code to edit team roster here
                    break;
                case 4:
                    Console.WriteLine("Viewing player stats...");
                    // Add code to view player stats here
                    break;
                case 5:
                    Console.WriteLine("Exiting Fantasy Sports Manager. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
