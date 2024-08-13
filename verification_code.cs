
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of the top of the frustum:");
        double topRadius = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the radius of the base of the frustum:");
        double baseRadius = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum:");
        double height = double.Parse(Console.ReadLine());

        double slantHeight = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(baseRadius - topRadius, 2));

        double lateralSurfaceArea = Math.PI * (topRadius + baseRadius) * slantHeight;

        double topArea = Math.PI * Math.Pow(topRadius, 2);
        double baseArea = Math.PI * Math.Pow(baseRadius, 2);

        double area = topArea + baseArea + lateralSurfaceArea;

        Console.WriteLine($"The area of the frustum of the cone is: {area}");
    }
}
