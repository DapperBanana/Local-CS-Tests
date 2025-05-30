
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text-Based RPG Game!");
        Console.WriteLine("Choose your character class:");
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");
        Console.WriteLine("3. Rogue");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You have selected the Warrior class. Get ready for battle!");
                break;
            case 2:
                Console.WriteLine("You have selected the Mage class. Prepare to cast spells!");
                break;
            case 3:
                Console.WriteLine("You have selected the Rogue class. Stealth and agility will be your allies.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }

        Console.WriteLine("Game Over. Thanks for playing!");
    }
}
