
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the RPG Game!");
        Console.WriteLine("Choose your character class:");
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.WriteLine("You have chosen the Warrior class!");
                Console.WriteLine("Your strength and courage will guide you through battles.");
                break;
            case "2":
                Console.WriteLine("You have chosen the Mage class!");
                Console.WriteLine("Harness the power of magic to defeat your enemies.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                break;
        }

        Console.WriteLine("Let the adventure begin!");
    }
}
