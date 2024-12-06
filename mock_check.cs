
using System;

class Program
{
    static void Main()
    {
        int fuel = 100;
        int health = 100;

        Console.WriteLine("Welcome to the Spaceship Game!");
        Console.WriteLine("Your spaceship has 100 fuel and 100 health.");
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Refuel");
            Console.WriteLine("2. Repair");
            Console.WriteLine("3. Exit");
            Console.WriteLine();

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please try again.");
                Console.WriteLine();
                continue;
            }

            switch (choice)
            {
                case 1:
                    fuel += 20;
                    Console.WriteLine("Fuel refilled by 20.");
                    break;
                case 2:
                    health += 20;
                    Console.WriteLine("Health repaired by 20.");
                    break;
                case 3:
                    Console.WriteLine("Exiting game.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Current stats:");
            Console.WriteLine("Fuel: " + fuel);
            Console.WriteLine("Health: " + health);
            Console.WriteLine();
        }
    }
}
