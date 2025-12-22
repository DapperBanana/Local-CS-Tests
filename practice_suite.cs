using System;
using System.Threading;

class TrafficSimulation
{
    static char[] road = new char[20];
    static int carPosition = 0;
    static bool isRunning = true;

    static void Main()
    {
        // Initialize the road with empty spaces
        for (int i = 0; i < road.Length; i++)
        {
            road[i] = ' ';
        }

        Thread simulationThread = new Thread(SimulateTraffic);
        simulationThread.Start();

        Console.WriteLine("Press any key to stop the simulation...");
        Console.ReadKey();
        isRunning = false;
        simulationThread.Join();
        Console.WriteLine("Simulation stopped.");
    }

    static void SimulateTraffic()
    {
        while (isRunning)
        {
            // Clear the road
            for (int i = 0; i < road.Length; i++)
            {
                road[i] = ' ';
            }

            // Move the car forward
            if (carPosition >= road.Length)
            {
                carPosition = 0; // Loop back to start
            }

            // Place the car in the current position
            road[carPosition] = 'A';

            // Display the road
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(new string(road));
            Console.WriteLine("Use arrow keys to add cars or press any key to stop.");

            // Wait for a short interval
            Thread.Sleep(200);

            // Move car forward for next iteration
            carPosition++;
        }
    }
}