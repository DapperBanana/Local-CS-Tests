
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Space Exploration game!");
        Console.WriteLine("You are the captain of a space ship and your mission is to explore the galaxy.");
        
        int fuel = 100;
        int planetsVisited = 0;
        
        while (true)
        {
            Console.WriteLine("\nCurrent fuel level: " + fuel);
            Console.WriteLine("Planets visited: " + planetsVisited);
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Visit a planet");
            Console.WriteLine("2. Refuel");
            Console.WriteLine("3. Quit");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            
            if (choice == 1)
            {
                if (fuel >= 10)
                {
                    Console.WriteLine("You have reached a new planet!");
                    planetsVisited++;
                    fuel -= 10;
                }
                else
                {
                    Console.WriteLine("You don't have enough fuel to visit a new planet. Refuel first.");
                }
            }
            else if (choice == 2)
            {
                fuel = 100;
                Console.WriteLine("Your fuel tank has been refilled.");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Thanks for playing! Final stats:");
                Console.WriteLine("Fuel remaining: " + fuel);
                Console.WriteLine("Planets visited: " + planetsVisited);
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose again.");
            }
        }
    }
}
