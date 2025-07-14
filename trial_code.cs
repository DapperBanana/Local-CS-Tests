
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text-Based RPG Game!");

        Console.WriteLine("Choose your class:");
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");

        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            Console.WriteLine("You have chosen the Warrior class.");
            Console.WriteLine("Your strength will help you in battles.");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("You encounter a fierce dragon! What will you do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Run away");

            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("You attack the dragon with your sword!");
                Console.WriteLine("You defeated the dragon! Congratulations!");
            }
            else
            {
                Console.WriteLine("You run away from the dragon and live to fight another day.");
            }
        }
        else if (userInput == "2")
        {
            Console.WriteLine("You have chosen the Mage class.");
            Console.WriteLine("Your magical abilities will aid you in battles.");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("You encounter a group of goblins! What will you do?");
            Console.WriteLine("1. Cast a fireball spell");
            Console.WriteLine("2. Use a teleportation spell to escape");

            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("You cast a fireball spell and defeat the goblins!");
                Console.WriteLine("Victory is yours!");
            }
            else
            {
                Console.WriteLine("You escape using a teleportation spell and avoid the goblins.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please choose a valid option.");
        }

        Console.WriteLine("Thank you for playing the Text-Based RPG Game!");
    }
}
