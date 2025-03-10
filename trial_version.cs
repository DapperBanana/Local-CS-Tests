
using System;

class Program
{
    static void Main()
    {
        int x1, y1, z1;
        int x2, y2, z2;

        Console.WriteLine("Enter the coordinates of the first point:");
        Console.Write("x1 = ");
        x1 = int.Parse(Console.ReadLine());
        Console.Write("y1 = ");
        y1 = int.Parse(Console.ReadLine());
        Console.Write("z1 = ");
        z1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coordinates of the second point:");
        Console.Write("x2 = ");
        x2 = int.Parse(Console.ReadLine());
        Console.Write("y2 = ");
        y2 = int.Parse(Console.ReadLine());
        Console.Write("z2 = ");
        z2 = int.Parse(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        Console.WriteLine($"The distance between the two points is: {distance}");
    }
}
