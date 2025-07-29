
using System;

class FrustumOfConeAreaCalculator
{
    static void Main()
    {
        double radius1, radius2, height;

        Console.WriteLine("Enter the radius of the top base of the frustum:");
        radius1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the radius of the bottom base of the frustum:");
        radius2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum:");
        height = Convert.ToDouble(Console.ReadLine());

        double slantHeight = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius1 - radius2, 2));
        double lateralArea = Math.PI * (radius1 + radius2) * slantHeight;
        double baseArea1 = Math.PI * Math.Pow(radius1, 2);
        double baseArea2 = Math.PI * Math.Pow(radius2, 2);
        double totalArea = lateralArea + baseArea1 + baseArea2;

        Console.WriteLine($"The area of the frustum of the cone is: {totalArea}");
    }
}

