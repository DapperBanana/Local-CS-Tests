
using System;

class TrafficSimulator
{
    static void Main()
    {
        int numCars = 5;
        int roadLength = 10;
        char[] road = new char[roadLength];

        Random rand = new Random();

        // Initialize road with cars
        for (int i = 0; i < numCars; i++)
        {
            int position = rand.Next(roadLength);
            road[position] = 'C';
        }

        // Main simulation loop
        while (true)
        {
            // Clear road
            Array.Clear(road, 0, road.Length);

            // Move cars
            for (int i = 0; i < numCars; i++)
            {
                int position = rand.Next(roadLength);
                road[position] = 'C';
            }

            // Display road
            Console.WriteLine(new string(road));

            // Pause for a moment
            System.Threading.Thread.Sleep(1000);
        }
    }
}
