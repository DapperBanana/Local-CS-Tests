
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Space Explorer!");
        Console.WriteLine("You are the captain of a spaceship exploring the galaxy.");

        int fuel = 100;
        int credits = 0;
        int planetsExplored = 0;

        while (true)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Explore a new planet");
            Console.WriteLine("2. Refuel your spaceship");
            Console.WriteLine("3. Check status");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You explore a new planet...");
                    fuel -= 20;
                    credits += 50;
                    planetsExplored++;
                    break;
                case 2:
                    Console.WriteLine("You refuel your spaceship...");
                    fuel = 100;
                    credits -= 30;
                    break;
                case 3:
                    Console.WriteLine("Fuel: " + fuel);
                    Console.WriteLine("Credits: " + credits);
                    Console.WriteLine("Planets explored: " + planetsExplored);
                    break;
                case 4:
                    Console.WriteLine("Thanks for playing Space Explorer!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (fuel <= 0)
            {
                Console.WriteLine("Your spaceship is out of fuel. Game over!");
                break;
            }
        }
    }
}
