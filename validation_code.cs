
using System;
using System.Threading;

class TrafficSimulation
{
    static void Main()
    {
        Console.WriteLine("Traffic Simulation\n");

        int roadLength = 20;
        int carPosition = 0;

        while (true)
        {
            Console.Clear();

            // Draw cars on the road
            Console.Write(new string('-', carPosition));
            Console.Write("o");
            Console.Write(new string('-', roadLength - carPosition - 1));
            Console.WriteLine();

            // Move car forward
            carPosition = (carPosition + 1) % roadLength;

            // Delay for 200 milliseconds
            Thread.Sleep(200);
        }
    }
}
