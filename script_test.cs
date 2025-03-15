
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Traffic Simulation!");

        while (true)
        {
            Console.WriteLine("Cars are moving on the road...");

            // Simulating traffic flow
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Car ");
                Thread.Sleep(500);
            }

            Console.WriteLine("\nTraffic light turned red, cars stopped.");

            // Simulating traffic light turning red
            Thread.Sleep(2000);

            Console.WriteLine("Traffic light turned green, cars can now move.");

            // Simulating cars moving again
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Car ");
                Thread.Sleep(500);
            }

            Console.WriteLine("\n---------- Next cycle ----------");
        }
    }
}
