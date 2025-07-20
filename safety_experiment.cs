
using System;

class Program
{
    static void Main()
    {
        int fuel = 100;
        int distance = 0;

        Console.WriteLine("Welcome to the Spaceship Game!");
        Console.WriteLine("You have 100 fuel and are starting at distance 0.");

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Travel to a new planet");
            Console.WriteLine("2. Refuel the spaceship");
            Console.WriteLine("3. Exit the game");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (fuel < 10)
                    {
                        Console.WriteLine("Not enough fuel to travel. Refuel first.");
                    }
                    else
                    {
                        fuel -= 10;
                        distance += 10;
                        Console.WriteLine("Traveled 10 light-years. Current distance: " + distance);
                    }
                    break;

                case 2:
                    fuel = 100;
                    Console.WriteLine("Spaceship refueled. Current fuel: 100");
                    break;

                case 3:
                    Console.WriteLine("Exiting the game...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (distance >= 100)
            {
                Console.WriteLine("\nCongratulations! You have reached your destination!");
                return;
            }
        }
    }
}
