
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Space Adventure!");
        Console.WriteLine("You are the pilot of a spaceship, and your mission is to explore the galaxy.");
        
        int fuel = 100;
        int distance = 0;
        
        while (true)
        {
            Console.WriteLine("\nCurrent Status:");
            Console.WriteLine("Fuel: " + fuel);
            Console.WriteLine("Distance Traveled: " + distance);
            
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Travel to a new planet");
            Console.WriteLine("2. Refuel your spaceship");
            Console.WriteLine("3. Exit the game");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Random rnd = new Random();
                    int fuelCost = rnd.Next(10, 20);
                    int distanceTraveled = rnd.Next(50, 100);
                    
                    if (fuel - fuelCost < 0)
                    {
                        Console.WriteLine("Not enough fuel to travel to a new planet. Refuel your spaceship.");
                    }
                    else
                    {
                        Console.WriteLine("Traveling to a new planet...");
                        fuel -= fuelCost;
                        distance += distanceTraveled;
                        Console.WriteLine("You have traveled " + distanceTraveled + " light years.");
                    }
                    break;
                
                case 2:
                    fuel = 100;
                    Console.WriteLine("Your spaceship has been refueled.");
                    break;
                
                case 3:
                    Console.WriteLine("Exiting the game. Goodbye!");
                    Environment.Exit(0);
                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
