
using System;

class Program
{
    static void Main()
    {
        int fuel = 100;
        int distance = 0;

        Console.WriteLine("Welcome to Space Adventure!");
        Console.WriteLine("Your spaceship is ready to launch.");

        while (true)
        {
            Console.WriteLine("\nCurrent Fuel: " + fuel);
            Console.WriteLine("Current Distance: " + distance);

            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Travel to a new planet");
            Console.WriteLine("2. Refuel the spaceship");
            Console.WriteLine("3. Quit the game");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (fuel < 10)
                    {
                        Console.WriteLine("Not enough fuel to travel. Refuel first.");
                    }
                    else
                    {
                        distance += 10;
                        fuel -= 10;
                        Console.WriteLine("You have traveled to a new planet!");
                    }
                    break;

                case 2:
                    fuel = 100;
                    Console.WriteLine("Spaceship refueled.");
                    break;

                case 3:
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
