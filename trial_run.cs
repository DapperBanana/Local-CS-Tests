
using System;

class TrafficSimulation
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Traffic Simulation!");

        while (true)
        {
            Console.WriteLine("\n1. Start simulation");
            Console.WriteLine("2. Exit");

            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\nSimulation started...");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"\nTraffic light is green - Car {i + 1} can pass");
                }

                Console.WriteLine("\nSimulation ended...");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Exiting the program...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
