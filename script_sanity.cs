
using System;
using System.Threading;

class TrafficSimulation
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Traffic Simulation!\n\n");

        while (true)
        {
            // Generate random traffic condition
            Random rand = new Random();
            int trafficLevel = rand.Next(1, 4); // 1 - low traffic, 2 - medium traffic, 3 - high traffic

            // Display traffic condition
            Console.WriteLine("Current Traffic Condition: ");
            switch (trafficLevel)
            {
                case 1:
                    Console.WriteLine("Low Traffic\n");
                    break;
                case 2:
                    Console.WriteLine("Medium Traffic\n");
                    break;
                case 3:
                    Console.WriteLine("High Traffic\n");
                    break;
            }

            // Simulate traffic flow
            Console.WriteLine("Cars moving...\n");
            Thread.Sleep(2000); // 2 second delay

            // Simulate traffic light changes
            Console.WriteLine("Traffic light changing...\n");
            Thread.Sleep(1000); // 1 second delay

            // Display traffic light status
            Console.WriteLine("Traffic Light Status: Green\n");

            // Simulate cars stopping at red light
            Console.WriteLine("Cars stopping at red light...\n");
            Thread.Sleep(2000); // 2 second delay

            // Display traffic light status
            Console.WriteLine("Traffic Light Status: Red\n");

            // Simulate light changes again
            Console.WriteLine("Traffic light changing...\n");
            Thread.Sleep(1000); // 1 second delay

            // Increment time
            Console.WriteLine("Time elapsed...\n");
            Thread.Sleep(1000); // 1 second delay

            Console.Clear();
        }
    }
}
