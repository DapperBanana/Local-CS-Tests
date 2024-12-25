
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of the larger base of the frustum:");
        double radius1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the radius of the smaller base of the frustum:");
        double radius2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum:");
        double height = Convert.ToDouble(Console.ReadLine());

        double slantHeight = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius1 - radius2, 2));
        double lateralSurfaceArea = Math.PI * (radius1 + radius2) * slantHeight;

        double baseArea1 = Math.PI * Math.Pow(radius1, 2);
        double baseArea2 = Math.PI * Math.Pow(radius2, 2);
        double frustumArea = baseArea1 + baseArea2 + lateralSurfaceArea;

        Console.WriteLine($"The lateral surface area of the frustum is: {lateralSurfaceArea}");
        Console.WriteLine($"The total surface area of the frustum is: {frustumArea}");
    }
}
