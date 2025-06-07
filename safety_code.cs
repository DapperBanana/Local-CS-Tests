
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int numCars = 3;
        int roadLength = 10;
        int speed = 500;

        string road = new string('-', roadLength);

        for (int i = 0; i < roadLength; i++)
        {
            Console.Clear();
            Console.WriteLine(road);

            for (int j = 0; j < numCars; j++)
            {
                road = road.Remove(i, 1);
                road = road.Insert(i, ">");
                Console.WriteLine(road);

                Thread.Sleep(speed);
            }
        }

        Console.WriteLine("Simulation finished. Press any key to exit.");
        Console.ReadKey();
    }
}
