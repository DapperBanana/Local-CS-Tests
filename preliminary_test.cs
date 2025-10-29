
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Space Explorer!");

        List<string> planets = new List<string> { "Mars", "Jupiter", "Saturn", "Neptune", "Pluto" };

        string currentPlanet = "Earth";

        while (true)
        {
            Console.WriteLine($"You are currently on {currentPlanet}");
            Console.WriteLine("Where would you like to go next? (Type 'quit' to exit)");

            foreach (string planet in planets)
            {
                if (planet != currentPlanet)
                {
                    Console.WriteLine(planet);
                }
            }

            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            if (planets.Contains(input))
            {
                Console.WriteLine($"Traveling to {input}...");
                currentPlanet = input;
            }
            else
            {
                Console.WriteLine("Invalid planet! Please try again.");
            }
        }

        Console.WriteLine("Thanks for playing Space Explorer!");
    }
}
