
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Space Explorer!");
        Console.WriteLine("You are in a spaceship and have to explore the galaxy.");

        Console.WriteLine("Choose a direction to explore: ");
        Console.WriteLine("1. North");
        Console.WriteLine("2. East");
        Console.WriteLine("3. South");
        Console.WriteLine("4. West");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.WriteLine("You traveled North and discovered an alien planet.");
                break;
            case "2":
                Console.WriteLine("You traveled East and found a black hole.");
                break;
            case "3":
                Console.WriteLine("You traveled South and encountered a fleet of enemy ships.");
                break;
            case "4":
                Console.WriteLine("You traveled West and stumbled upon a deserted space station.");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.WriteLine("Game over. Thanks for playing!");
    }
}
