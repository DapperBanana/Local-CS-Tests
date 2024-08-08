
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Space Exploration Game!");
        Console.WriteLine("You are a space explorer in search of new galaxies to explore.");
        Console.WriteLine("Choose your next destination:");

        while (true)
        {
            Console.WriteLine("\n1. Alpha Centauri");
            Console.WriteLine("2. Andromeda Galaxy");
            Console.WriteLine("3. Milky Way Black Hole");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You have arrived at Alpha Centauri. It is a binary star system.");
                    break;
                case "2":
                    Console.WriteLine("You have reached the Andromeda Galaxy. It is the closest spiral galaxy to the Milky Way.");
                    break;
                case "3":
                    Console.WriteLine("You are near the Milky Way Black Hole. Proceed with caution.");
                    break;
                case "4":
                    Console.WriteLine("Thanks for playing the Space Exploration Game!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
