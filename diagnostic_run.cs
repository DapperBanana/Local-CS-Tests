
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Space Explorer!");

        // initialize player's stats
        int fuel = 100;
        int food = 100;
        int credits = 0;

        bool gameOver = false;

        while (!gameOver)
        {
            Console.WriteLine("\n1. Explore a planet");
            Console.WriteLine("2. Refuel spaceship");
            Console.WriteLine("3. Buy food");
            Console.WriteLine("4. View stats");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ExplorePlanet(ref fuel, ref food, ref credits);
                    break;
                case "2":
                    RefuelSpaceship(ref fuel, ref credits);
                    break;
                case "3":
                    BuyFood(ref food, ref credits);
                    break;
                case "4":
                    ViewStats(fuel, food, credits);
                    break;
                case "5":
                    gameOver = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (fuel <= 0 || food <= 0)
            {
                Console.WriteLine("Game over! Your spaceship ran out of fuel or food.");
                gameOver = true;
            }
        }
    }

    static void ExplorePlanet(ref int fuel, ref int food, ref int credits)
    {
        Console.WriteLine("You have discovered a new planet!");

        Random rnd = new Random();
        int fuelCost = rnd.Next(10, 30);
        int foodCost = rnd.Next(5, 15);
        int creditsEarned = rnd.Next(20, 50);

        Console.WriteLine($"Exploring this planet will cost {fuelCost} fuel and {foodCost} food.");
        Console.WriteLine($"You earned {creditsEarned} credits.");

        fuel -= fuelCost;
        food -= foodCost;
        credits += creditsEarned;
    }

    static void RefuelSpaceship(ref int fuel, ref int credits)
    {
        int fuelCost = 50;

        if (credits >= fuelCost)
        {
            Console.WriteLine($"Refueling the spaceship will cost {fuelCost} credits.");
            fuel += 50;
            credits -= fuelCost;
        }
        else
        {
            Console.WriteLine("You don't have enough credits to refuel the spaceship.");
        }
    }

    static void BuyFood(ref int food, ref int credits)
    {
        int foodCost = 20;

        if (credits >= foodCost)
        {
            Console.WriteLine($"Buying food will cost {foodCost} credits.");
            food += 20;
            credits -= foodCost;
        }
        else
        {
            Console.WriteLine("You don't have enough credits to buy food.");
        }
    }

    static void ViewStats(int fuel, int food, int credits)
    {
        Console.WriteLine($"Fuel: {fuel}");
        Console.WriteLine($"Food: {food}");
        Console.WriteLine($"Credits: {credits}");
    }
}
