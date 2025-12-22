using System;

namespace SpaceExplorationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Space Exploration Game";

            // Player stats
            int fuel = 100;
            int credits = 50;
            int distanceTraveled = 0;

            Random rand = new Random();

            Console.WriteLine("Welcome to the Space Exploration Game!");
            Console.WriteLine("You are the captain of a spaceship embarking on a journey through the galaxy.\n");

            bool gameRunning = true;

            while (gameRunning)
            {
                Console.WriteLine("Current Status:");
                Console.WriteLine($"Fuel: {fuel}");
                Console.WriteLine($"Credits: {credits}");
                Console.WriteLine($"Distance Traveled: {distanceTraveled} light-years\n");

                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Travel");
                Console.WriteLine("2. Visit Space Station");
                Console.WriteLine("3. Mine for Resources");
                Console.WriteLine("4. Quit");
                Console.Write("Enter your choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Travel
                        Console.Write("Enter distance to travel (light-years): ");
                        if (int.TryParse(Console.ReadLine(), out int travelDistance) && travelDistance > 0)
                        {
                            int fuelNeeded = travelDistance * 2; // Consumes 2 units of fuel per light-year
                            if (fuel >= fuelNeeded)
                            {
                                fuel -= fuelNeeded;
                                distanceTraveled += travelDistance;
                                Console.WriteLine($"You traveled {travelDistance} light-years.");
                                // Random event after travel
                                int eventChance = rand.Next(1, 101);
                                if (eventChance <= 30)
                                {
                                    Console.WriteLine("Encountered an alien ship! The encounter was peaceful, but it cost you some credits for communication.");
                                    int creditsLost = rand.Next(5, 16);
                                    credits -= creditsLost;
                                    Console.WriteLine($"Credits lost: {creditsLost}");
                                }
                                else if (eventChance <= 50)
                                {
                                    Console.WriteLine("You found a derelict ship. Donated some credits for salvage rights.");
                                    int creditsGained = rand.Next(10, 21);
                                    credits += creditsGained;
                                    Console.WriteLine($"Credits gained: {creditsGained}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Not enough fuel for that journey.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid distance input.");
                        }
                        break;
                    case "2":
                        // Visit Space Station
                        Console.WriteLine("Visiting space station...");
                        Console.WriteLine("Options:");
                        Console.WriteLine("a. Refuel (cost: 10 credits for 50 fuel)");
                        Console.WriteLine("b. Repair Ship (cost: 20 credits)");
                        Console.WriteLine("c. Purchase Supplies (cost: 5 credits)");
                        Console.Write("Choose an option (a-c): ");
                        string stationOption = Console.ReadLine();

                        switch (stationOption.ToLower())
                        {
                            case "a":
                                if (credits >= 10)
                                {
                                    credits -= 10;
                                    fuel += 50;
                                    Console.WriteLine("Refueled 50 units of fuel.");
                                }
                                else
                                {
                                    Console.WriteLine("Not enough credits.");
                                }
                                break;
                            case "b":
                                if (credits >= 20)
                                {
                                    credits -= 20;
                                    Console.WriteLine("Ship repaired.");
                                }
                                else
                                {
                                    Console.WriteLine("Not enough credits.");
                                }
                                break;
                            case "c":
                                if (credits >= 5)
                                {
                                    credits -= 5;
                                    Console.WriteLine("Supplies purchased.");
                                }
                                else
                                {
                                    Console.WriteLine("Not enough credits.");
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid option.");
                                break;
                        }
                        break;
                    case "3":
                        // Mine for resources
                        Console.WriteLine("Mining...");
                        int oreFound = rand.Next(5, 21);
                        int creditsEarned = oreFound * 2;
                        credits += creditsEarned;
                        Console.WriteLine($"You mined ore worth {creditsEarned} credits.");
                        break;
                    case "4":
                        // Quit
                        Console.WriteLine("Ending your journey. Safe travels, captain!");
                        gameRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1-4.");
                        break;
                }

                Console.WriteLine();

                // Check for game over conditions
                if (fuel <= 0)
                {
                    Console.WriteLine("You've run out of fuel and cannot continue. Game over.");
                    gameRunning = false;
                }
            }

            Console.WriteLine($"Final Stats:\nDistance Traveled: {distanceTraveled} light-years");
            Console.WriteLine($"Remaining Fuel: {fuel}");
            Console.WriteLine($"Credits: {credits}");
        }
    }
}