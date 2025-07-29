
using System;

class Program
{
    static void Main()
    {
        int health = 100;
        int fuel = 100;
        int distance = 0;
        
        Console.WriteLine("Welcome to the Spaceship Game!");

        while (health > 0 && fuel > 0)
        {
            Console.WriteLine("\nCurrent stats:");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Fuel: " + fuel);
            Console.WriteLine("Distance traveled: " + distance);

            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Travel to a planet");
            Console.WriteLine("2. Refuel spaceship");
            Console.WriteLine("3. Exit game");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Traveling to a planet...");
                    health -= 10;
                    fuel -= 20;
                    distance += 50;
                    break;
                case 2:
                    Console.WriteLine("Refueling spaceship...");
                    fuel = 100;
                    break;
                case 3:
                    Console.WriteLine("Exiting game...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        if (health <= 0)
        {
            Console.WriteLine("Your spaceship has been destroyed. Game over!");
        }

        if (fuel <= 0)
        {
            Console.WriteLine("You ran out of fuel. Game over!");
        }
    }
}
