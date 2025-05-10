
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Spaceship Game!");
        Console.WriteLine("You are the captain of a spaceship and your mission is to navigate through space.");

        int fuel = 100;
        int health = 100;

        while (true)
        {
            Console.WriteLine("\nCurrent Status:");
            Console.WriteLine("Fuel: " + fuel);
            Console.WriteLine("Health: " + health);

            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Go forward");
            Console.WriteLine("2. Refuel");
            Console.WriteLine("3. Repair ship");
            Console.WriteLine("4. Quit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Moving forward...");
                    fuel -= 10;
                    health -= 5;
                    break;
                case 2:
                    Console.WriteLine("Refueling...");
                    fuel += 20;
                    break;
                case 3:
                    Console.WriteLine("Repairing ship...");
                    health += 10;
                    break;
                case 4:
                    Console.WriteLine("Thanks for playing!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (fuel <= 0 || health <= 0)
            {
                Console.WriteLine("Game over!");
                break;
            }
        }
    }
}
