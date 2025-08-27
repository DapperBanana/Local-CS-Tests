
using System;

class Program
{
    static void Main()
    {
        double x1, y1, z1, x2, y2, z2;
        
        Console.WriteLine("Enter the coordinates of point 1 (x y z):");
        string[] point1 = Console.ReadLine().Split(' ');
        x1 = double.Parse(point1[0]);
        y1 = double.Parse(point1[1]);
        z1 = double.Parse(point1[2]);
        
        Console.WriteLine("Enter the coordinates of point 2 (x y z):");
        string[] point2 = Console.ReadLine().Split(' ');
        x2 = double.Parse(point2[0]);
        y2 = double.Parse(point2[1]);
        z2 = double.Parse(point2[2]);
        
        double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);
        
        Console.WriteLine($"The distance between point 1 and point 2 is: {distance}");
    }
    
    static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double dz = z2 - z1;
        
        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}
