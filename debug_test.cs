
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Space Explorer!");

        string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

        Console.WriteLine("Choose a planet to explore by entering its number:");
        for (int i = 0; i < planets.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {planets[i]}");
        }

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice >= 1 && choice <= planets.Length)
        {
            Console.WriteLine($"You are now exploring {planets[choice - 1]}!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("Mission complete! Would you like to explore another planet? (y/n)");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Thank you for playing Space Explorer!");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please choose a valid number.");
            Main();
        }
    }
}
