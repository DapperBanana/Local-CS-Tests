
using System;

class Program
{
    static void Main()
    {
        int health = 100;
        int ammo = 50;

        Console.WriteLine("Welcome to the Spaceship Game!");
        Console.WriteLine("Your spaceship is equipped with 100 health and 50 ammo.");
        
        while (true)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Attack an enemy");
            Console.WriteLine("2. Repair the spaceship");
            Console.WriteLine("3. Quit the game");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (ammo < 10)
                    {
                        Console.WriteLine("You are out of ammo! Choose another action.");
                    }
                    else
                    {
                        Console.WriteLine("You attack an enemy. It takes 10 damage.");
                        ammo -= 10;
                    }
                    break;
                case 2:
                    if (health < 100)
                    {
                        Console.WriteLine("You repair the spaceship. Health is restored to 100.");
                        health = 100;
                    }
                    else
                    {
                        Console.WriteLine("Your spaceship is already at full health.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Thanks for playing!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Current Status:");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Ammo: " + ammo);
        }
    }
}
