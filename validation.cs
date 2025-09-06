
using System;

class Program
{
    static void Main()
    {
        double x1 = 1, y1 = 2, z1 = 3; // coordinates of point 1
        double x2 = 4, y2 = 5, z2 = 6; // coordinates of point 2

        double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);
        Console.WriteLine("The distance between the two points is: " + distance);
    }

    static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        return distance;
    }
}
