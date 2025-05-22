
using System;

namespace TrafficSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCars = 5;
            int roadLength = 10;

            int[] positions = new int[numCars];
            Random rand = new Random();

            while (true)
            {
                Console.Clear();
                
                for (int i = 0; i < numCars; i++)
                {
                    positions[i] += rand.Next(0, 3);
                    
                    if (positions[i] >= roadLength)
                    {
                        positions[i] = 0;
                    }
                }

                for (int i = 0; i < numCars; i++)
                {
                    string road = new string('-', roadLength);
                    char[] roadArray = road.ToCharArray();
                    roadArray[positions[i]] = 'C';
                    Console.WriteLine(new string(roadArray));
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
