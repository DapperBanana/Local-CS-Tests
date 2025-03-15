
using System;

class Program
{
    static void Main()
    {
        double x1, y1, z1, x2, y2, z2;

        Console.WriteLine("Enter the coordinates of point 1 (x y z):");
        string[] point1Coords = Console.ReadLine().Split(' ');
        x1 = Double.Parse(point1Coords[0]);
        y1 = Double.Parse(point1Coords[1]);
        z1 = Double.Parse(point1Coords[2]);

        Console.WriteLine("Enter the coordinates of point 2 (x y z):");
        string[] point2Coords = Console.ReadLine().Split(' ');
        x2 = Double.Parse(point2Coords[0]);
        y2 = Double.Parse(point2Coords[1]);
        z2 = Double.Parse(point2Coords[2]);

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        Console.WriteLine($"The distance between point 1 and point 2 is: {distance}");
    }
}
