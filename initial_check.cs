
using System;

class Program
{
    static void Main()
    {
        double x1, y1, z1, x2, y2, z2;

        Console.WriteLine("Enter the coordinates of Point 1 (x y z):");
        string[] point1 = Console.ReadLine().Split(' ');
        x1 = double.Parse(point1[0]);
        y1 = double.Parse(point1[1]);
        z1 = double.Parse(point1[2]);

        Console.WriteLine("Enter the coordinates of Point 2 (x y z):");
        string[] point2 = Console.ReadLine().Split(' ');
        x2 = double.Parse(point2[0]);
        y2 = double.Parse(point2[1]);
        z2 = double.Parse(point2[2]);

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        Console.WriteLine($"The distance between Point 1 and Point 2 is: {distance}");
    }
}
