
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of the bottom base of the frustum:");
        double radius1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the radius of the top base of the frustum:");
        double radius2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum:");
        double height = Convert.ToDouble(Console.ReadLine());

        double slantHeight = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius1 - radius2, 2));
        double lateralSurfaceArea = Math.PI * (radius1 + radius2) * slantHeight;

        double bottomBaseArea = Math.PI * Math.Pow(radius1, 2);
        double topBaseArea = Math.PI * Math.Pow(radius2, 2);
        double frustumArea = bottomBaseArea + topBaseArea + lateralSurfaceArea;

        Console.WriteLine($"The area of the frustum of the cone is: {frustumArea}");
    }
}
