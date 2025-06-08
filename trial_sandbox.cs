
using System;
using System.Threading;

class TrafficSimulation
{
    static void Main()
    {
        int carSpeed = 500; // car speed in milliseconds
        int lightDuration = 2000; // duration of traffic light in milliseconds

        Console.WriteLine("Starting Traffic Simulation...");

        while (true)
        {
            Console.WriteLine("Green light - Cars are moving");
            Thread.Sleep(lightDuration);

            Console.WriteLine("Red light - Stop");
            Thread.Sleep(lightDuration);

            Console.WriteLine("Yellow light - Prepare to Stop");
            Thread.Sleep(lightDuration / 2);
        }
    }
}
