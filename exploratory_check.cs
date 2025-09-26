
using System;

class Program
{
    static void Main()
    {
        int health = 100;
        int fuel = 100;
        
        Console.WriteLine("Welcome to the Spaceship Game!");
        Console.WriteLine("Your spaceship has 100 health and 100 fuel.");
        
        while (health > 0 && fuel > 0)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Fly to a new planet");
            Console.WriteLine("2. Refuel your spaceship");
            Console.WriteLine("3. Quit the game");
            
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Flying to a new planet...");
                    health -= 10;
                    fuel -= 20;
                    Console.WriteLine("Health: " + health);
                    Console.WriteLine("Fuel: " + fuel);
                    break;
                    
                case 2:
                    Console.WriteLine("Refueling spaceship...");
                    fuel = 100;
                    Console.WriteLine("Fuel: " + fuel);
                    break;
                    
                case 3:
                    Console.WriteLine("Quitting the game...");
                    return;
                    
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        
        if (health <= 0)
        {
            Console.WriteLine("Your spaceship has been destroyed. Game over.");
        }
        else if (fuel <= 0)
        {
            Console.WriteLine("Your spaceship has run out of fuel. Game over.");
        }
    }
}
