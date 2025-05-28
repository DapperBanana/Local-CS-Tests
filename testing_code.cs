
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Traffic Simulation Program!");

        // Simulate traffic lights
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Green Light - Go!");
            System.Threading.Thread.Sleep(5000);

            Console.WriteLine("Yellow Light - Prepare to Stop!");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Red Light - Stop!");
            System.Threading.Thread.Sleep(5000);
        }

        Console.WriteLine("Simulation ended. Thank you for participating!");
    }
}
