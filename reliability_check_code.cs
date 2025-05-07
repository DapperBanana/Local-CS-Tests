
using System;

class Program
{
    static int fuel = 100;
    static int distance = 0;
    
    static void Main()
    {
        Console.WriteLine("Welcome to the Space Exploration Game!");
        
        while (true)
        {
            Console.WriteLine("1. Travel to a new planet");
            Console.WriteLine("2. Refuel your spaceship");
            Console.WriteLine("3. Check your current status");
            Console.WriteLine("4. Quit the game");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Travel();
                    break;
                case 2:
                    Refuel();
                    break;
                case 3:
                    CheckStatus();
                    break;
                case 4:
                    Console.WriteLine("Thank you for playing! Goodbye");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    
    static void Travel()
    {
        if (fuel >= 20)
        {
            Random rng = new Random();
            int distanceTraveled = rng.Next(10, 101);
            fuel -= distanceTraveled / 2;
            distance += distanceTraveled;
            Console.WriteLine($"Traveled {distanceTraveled} light years. Distance traveled: {distance} light years. Fuel remaining: {fuel}");
        }
        else
        {
            Console.WriteLine("Not enough fuel to travel. Refuel to continue.");
        }
    }
    
    static void Refuel()
    {
        fuel = 100;
        Console.WriteLine("Spaceship refueled. Fuel remaining: 100");
    }
    
    static void CheckStatus()
    {
        Console.WriteLine($"Current distance traveled: {distance} light years");
        Console.WriteLine($"Current fuel remaining: {fuel}");
    }
}
