
using System;

class Program
{
    static void Main()
    {
        double radius1, radius2, height;

        Console.Write("Enter the radius of the top circle: ");
        radius1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the radius of the bottom circle: ");
        radius2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the frustum: ");
        height = Convert.ToDouble(Console.ReadLine());

        double baseArea1 = Math.PI * Math.Pow(radius1, 2);
        double baseArea2 = Math.PI * Math.Pow(radius2, 2);

        double sideArea = Math.PI * (radius1 + radius2) * Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius1 - radius2, 2));

        double totalArea = baseArea1 + baseArea2 + sideArea;

        Console.WriteLine($"The area of the frustum of the cone is {totalArea}");
    }
}
