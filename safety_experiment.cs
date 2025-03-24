
using System;
using System.Threading;

class TrafficSimulation
{
    static void Main()
    {
        int trafficLightTimer = 0;
        bool isGreen = false;

        while (true)
        {
            if (trafficLightTimer == 0)
            {
                isGreen = !isGreen;
                trafficLightTimer = isGreen ? 10 : 5;
                Console.WriteLine(isGreen ? "Green light" : "Red light");
            }

            Thread.Sleep(1000);

            trafficLightTimer--;

            Console.Clear();
        }
    }
}
