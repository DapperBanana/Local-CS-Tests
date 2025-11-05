
using System;

class Program
{
    static void Main()
    {
        // Define the coordinates of point A
        double x1 = 1;
        double y1 = 2;
        double z1 = 3;

        // Define the coordinates of point B
        double x2 = 4;
        double y2 = 5;
        double z2 = 6;

        // Calculate the distance between points A and B
        double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);

        Console.WriteLine($"The distance between point A and point B is {distance}");
    }

    static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        return distance;
    }
}
