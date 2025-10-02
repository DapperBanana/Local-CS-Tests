
using System;

namespace TrafficSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCars = 10;
            int trafficLight = 0; // 0: red, 1: green

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Time: " + i);

                if (trafficLight == 0)
                {
                    Console.WriteLine("Traffic light is RED");
                    Console.WriteLine("Cars waiting: " + numCars);
                }
                else
                {
                    Console.WriteLine("Traffic light is GREEN");
                    if (numCars > 0)
                    {
                        int passedCars = Math.Min(numCars, 3);
                        Console.WriteLine(passedCars + " cars passed the intersection");
                        numCars -= passedCars;
                    }
                }

                if (i % 5 == 0) // toggle traffic light every 5 time steps
                {
                    trafficLight = (trafficLight + 1) % 2;
                }

                Console.WriteLine();
            }
        }
    }
}
