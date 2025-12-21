using System;

namespace SpaceExplorationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Space Explorer!");
            Console.WriteLine("Your mission: Explore the galaxy and discover new planets.\n");

            int fuel = 100;
            int distanceTraveled = 0;
            int planetsDiscovered = 0;
            bool gameRunning = true;

            while (gameRunning)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Travel");
                Console.WriteLine("2. Check Status");
                Console.WriteLine("3. Quit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter distance to travel (light-years): ");
                        if (int.TryParse(Console.ReadLine(), out int travelDistance) && travelDistance > 0)
                        {
                            int fuelNeeded = travelDistance * 10; // fuel consumption rate
                            if (fuel >= fuelNeeded)
                            {
                                fuel -= fuelNeeded;
                                distanceTraveled += travelDistance;
                                Console.WriteLine($"Traveling {travelDistance} light-years...");
                                Random rnd = new Random();
                                if (rnd.Next(0, 100) < 30) // 30% chance to discover a planet
                                {
                                    planetsDiscovered++;
                                    Console.WriteLine("Congratulations! You discovered a new planet!");
                                }
                                else
                                {
                                    Console.WriteLine("No planets found on this voyage.");
                                }
                                Console.WriteLine($"Remaining fuel: {fuel}");
                            }
                            else
                            {
                                Console.WriteLine("Not enough fuel for this journey.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid distance. Please enter a positive integer.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\n--- Status ---");
                        Console.WriteLine($"Total distance traveled: {distanceTraveled} light-years");
                        Console.WriteLine($"Remaining fuel: {fuel}");
                        Console.WriteLine($"Planets discovered: {planetsDiscovered}");
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine("Exiting the game. Safe travels!");
                        gameRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                        break;
                }

                if (fuel <= 0)
                {
                    Console.WriteLine("You have run out of fuel. The journey ends here.");
                    gameRunning = false;
                }
            }

            Console.WriteLine("Game Over. Thanks for playing!");
        }
    }
}