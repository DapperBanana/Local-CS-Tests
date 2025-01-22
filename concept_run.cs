
using System;

class Program
{
    static double CalculateFrustumArea(double r1, double r2, double h)
    {
        double baseArea = Math.PI * (r1 * r1);
        double topArea = Math.PI * (r2 * r2);
        double sideArea = Math.PI * (r1 + r2) * Math.Sqrt((r1 - r2) * (r1 - r2) + h * h);
        
        return baseArea + topArea + sideArea;
    }

    static void Main()
    {
        Console.WriteLine("Enter the radius of the smaller base of the frustum: ");
        double r1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the radius of the larger base of the frustum: ");
        double r2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum: ");
        double h = Convert.ToDouble(Console.ReadLine());

        double frustumArea = CalculateFrustumArea(r1, r2, h);
        Console.WriteLine($"The area of the frustum of the cone is: {frustumArea}");
    }
}
