
using System;

class Program
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

        double surfaceArea = CalculateFrustumArea(radius1, radius2, height);

        Console.WriteLine("The surface area of the frustum is: " + surfaceArea);
    }

    static double CalculateFrustumArea(double radius1, double radius2, double height)
    {
        double sideLength = Math.Sqrt((radius1 - radius2) * (radius1 - radius2) + height * height);

        double surfaceArea = Math.PI * (radius1 + radius2) * sideLength + Math.PI * (radius1 * radius1 + radius2 * radius2);

        return surfaceArea;
    }
}
