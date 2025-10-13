
using System;

class Program
{
    static void Main()
    {
        double radius1, radius2, height;

        Console.WriteLine("Enter the radius of the larger base of the frustum:");
        radius1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the radius of the smaller base of the frustum:");
        radius2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum:");
        height = Convert.ToDouble(Console.ReadLine());

        double slantHeight = Math.Sqrt(Math.Pow(radius1 - radius2, 2) + Math.Pow(height, 2));
        double lateralArea = Math.PI * (radius1 + radius2) * slantHeight;

        double baseArea1 = Math.PI * Math.Pow(radius1, 2);
        double baseArea2 = Math.PI * Math.Pow(radius2, 2);

        double surfaceArea = baseArea1 + baseArea2 + lateralArea;

        Console.WriteLine("The surface area of the frustum of the cone is: " + surfaceArea);
    }
}
