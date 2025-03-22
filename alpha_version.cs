
using System;

class Program
{
    static void Main()
    {
        int health = 100;
        int fuel = 50;
        int distance = 0;

        Console.WriteLine("Welcome to the spaceship game!");

        while (health > 0 && fuel > 0)
        {
            Console.WriteLine("\nCurrent stats:");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Fuel: {fuel}");
            Console.WriteLine($"Distance traveled: {distance}");

            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Travel to a new planet");
            Console.WriteLine("2. Refuel the spaceship");
            Console.WriteLine("3. Exit the game");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int travelDistance = new Random().Next(10, 101);
                    distance += travelDistance;
                    health -= travelDistance / 2;
                    fuel -= travelDistance / 5;
                    Console.WriteLine($"Traveled to a new planet! Distance traveled: {travelDistance}");
                    break;

                case 2:
                    fuel = 100;
                    Console.WriteLine("Refueled the spaceship to full capacity.");
                    break;

                case 3:
                    Console.WriteLine("Exiting the game...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }

        if (health <= 0)
        {
            Console.WriteLine("Your spaceship has been destroyed! Game over.");
        }
        else if (fuel <= 0)
        {
            Console.WriteLine("Your spaceship has run out of fuel! Game over.");
        }
    }
}
