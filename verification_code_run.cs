
using System;

class FrustumOfConeAreaCalculator
{
    static void Main()
    {
        double radius1, radius2, height;

        Console.WriteLine("Enter the radius1 of the frustum: ");
        radius1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the radius2 of the frustum: ");
        radius2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum: ");
        height = Convert.ToDouble(Console.ReadLine());

        double baseArea1 = Math.PI * Math.Pow(radius1, 2);
        double baseArea2 = Math.PI * Math.Pow(radius2, 2);
        double sideArea = Math.PI * (radius1 + radius2) * Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius1 - radius2, 2));

        double totalArea = Math.PI * (radius1 + radius2) * Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius1 - radius2, 2)) + baseArea1 + baseArea2;

        Console.WriteLine($"The total surface area of the frustum is: {totalArea}");
    }
}
