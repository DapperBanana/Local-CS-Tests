
using System;

class Program
{
    static void Main()
    {
        int health = 100;
        int fuel = 100;
        int enemiesDestroyed = 0;

        Console.WriteLine("Welcome to Space Battleship!\n");
        Console.WriteLine("Your spaceship is ready for battle.");

        while (health > 0 && fuel > 0)
        {
            Console.WriteLine($"\nHealth: {health} Fuel: {fuel} Enemies Destroyed: {enemiesDestroyed}");

            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Attack enemy ship");
            Console.WriteLine("2. Refuel");
            Console.WriteLine("3. Repair ship");
            Console.WriteLine("4. Quit game");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (fuel >= 10)
                    {
                        Console.WriteLine("You attack an enemy ship and destroy it!");
                        fuel -= 10;
                        enemiesDestroyed++;
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to attack.");
                    }
                    break;

                case 2:
                    fuel += 50;
                    Console.WriteLine("You refueled your spaceship.");
                    break;

                case 3:
                    health += 50;
                    Console.WriteLine("You repaired your spaceship.");
                    break;

                case 4:
                    Console.WriteLine("Game over. Final score:");
                    Console.WriteLine($"Health: {health} Fuel: {fuel} Enemies Destroyed: {enemiesDestroyed}");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("\nThanks for playing Space Battleship!");
    }
}
