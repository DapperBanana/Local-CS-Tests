
using System;

class Program
{
    static double CalculateFrustumArea(double r1, double r2, double h)
    {
        double l = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(r1 - r2, 2));
        double area = Math.PI * (r1 + r2) * l + Math.PI * Math.Pow(r1, 2) + Math.PI * Math.Pow(r2, 2);
        return area;
    }

    static void Main()
    {
        Console.Write("Enter the radius of the top base of the frustum: ");
        double r1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the radius of the bottom base of the frustum: ");
        double r2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the height of the frustum: ");
        double h = Convert.ToDouble(Console.ReadLine());
        
        double area = CalculateFrustumArea(r1, r2, h);
        Console.WriteLine($"The area of the frustum of the cone is {area:F2}");
    }
}
