
using System;

namespace FantasySportsManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fantasy Sports Manager!");

            Console.WriteLine("Select a sport: ");
            Console.WriteLine("1. Football");
            Console.WriteLine("2. Basketball");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    ManageFootballTeam();
                    break;
                case "2":
                    ManageBasketballTeam();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }

        static void ManageFootballTeam()
        {
            Console.WriteLine("You have selected Football.");

            // Add logic to manage football team here
        }

        static void ManageBasketballTeam()
        {
            Console.WriteLine("You have selected Basketball.");

            // Add logic to manage basketball team here
        }
    }
}
