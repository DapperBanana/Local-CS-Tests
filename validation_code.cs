
using System;

class Program
{
    static void Main()
    {
        // Define the coordinates of the two points
        double x1 = 1, y1 = 2, z1 = 3;
        double x2 = 4, y2 = 5, z2 = 6;

        // Calculate the distance
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        // Print the result
        Console.WriteLine($"The distance between the two points is: {distance}");
    }
}
