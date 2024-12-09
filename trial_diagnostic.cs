
using System;

class SpaceExplorationGame
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Space Exploration Game!");

        Console.WriteLine("You are a courageous astronaut on a solo mission to explore the galaxy.");
        Console.WriteLine("You are currently orbiting a new planet and need to make a choice on where to land your spacecraft.");

        Console.WriteLine("Choose your landing spot (1, 2, or 3):");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You have landed on a barren moon with no signs of life. Keep exploring!");
                break;
            case 2:
                Console.WriteLine("You have landed on a lush planet with alien creatures. Proceed with caution!");
                break;
            case 3:
                Console.WriteLine("You have landed on a rocky planet with valuable resources. Good job!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose 1, 2, or 3.");
                break;
        }

        Console.WriteLine("Mission complete. Thank you for playing!");
    }
}
