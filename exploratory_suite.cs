
using System;

class Program
{
    static void Main()
    {
        int fuel = 100;
        int resources = 0;

        Console.WriteLine("Welcome to Space Explorer!");
        Console.WriteLine("You are in a spaceship in a fictional galaxy.");

        while (true)
        {
            Console.WriteLine("\nFuel: " + fuel);
            Console.WriteLine("Resources: " + resources);
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Land on a planet");
            Console.WriteLine("2. Refuel spaceship");
            Console.WriteLine("3. Collect resources");
            Console.WriteLine("4. Quit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (fuel < 20)
                    {
                        Console.WriteLine("Not enough fuel to land on a planet. Refuel first!");
                    }
                    else
                    {
                        Console.WriteLine("Landing on a planet...");
                        fuel -= 20;
                        resources += 10;
                        Console.WriteLine("You collected 10 resources.");
                    }
                    break;

                case 2:
                    Console.WriteLine("Refueling spaceship...");
                    fuel = 100;
                    Console.WriteLine("Spaceship refueled.");
                    break;

                case 3:
                    Console.WriteLine("Collecting resources...");
                    resources += 5;
                    Console.WriteLine("You collected 5 resources.");
                    break;

                case 4:
                    Console.WriteLine("Thank you for playing Space Explorer!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }
    }
}
