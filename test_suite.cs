
using System;

namespace TrafficSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Traffic Simulation!");

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("1. Start simulation");
                Console.WriteLine("2. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        StartSimulation();
                        break;
                    case 2:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void StartSimulation()
        {
            Console.WriteLine("Simulation started...");

            Random rand = new Random();
            int seconds = 0;

            while (seconds < 60)
            {
                int carCount = rand.Next(0, 10);

                Console.WriteLine($"At {seconds} seconds: {carCount} cars on the road");

                seconds++;
                System.Threading.Thread.Sleep(1000); // Delay by 1 second
            }

            Console.WriteLine("Simulation ended...");
        }
    }
}
