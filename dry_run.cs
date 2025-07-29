
using System;

class Program
{
    static void Main()
    {
        int fuel = 100;
        int distance = 0;

        Console.WriteLine("Welcome to Space Exploration Game!");

        while (true)
        {
            Console.WriteLine("\nCurrent Distance Traveled: " + distance + " light years");
            Console.WriteLine("Fuel Remaining: " + fuel + "%");
            Console.WriteLine("1. Travel to a New Galaxy");
            Console.WriteLine("2. Refuel Ship");
            Console.WriteLine("3. Quit Game");

            Console.Write("\nEnter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (fuel >= 10)
                    {
                        distance += 10;
                        fuel -= 10;
                        Console.WriteLine("You have traveled 10 light years to a new galaxy!");
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to travel!");
                    }
                    break;
                case 2:
                    fuel = 100;
                    Console.WriteLine("Ship refueled to 100% fuel!");
                    break;
                case 3:
                    Console.WriteLine("Thanks for playing Space Exploration Game!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        }
    }
}
