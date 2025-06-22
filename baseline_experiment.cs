
using System;

class Program
{
    public static double CalculateFrustumArea(double r1, double r2, double h)
    {
        double area = Math.PI * (r1 + r2) * Math.Sqrt(Math.Pow(r1 - r2, 2) + Math.Pow(h, 2)) + Math.PI * Math.Pow(r1, 2) + Math.PI * Math.Pow(r2, 2);
        return area;
    }

    static void Main()
    {
        Console.WriteLine("Enter the radius of the larger base of the frustum: ");
        double r1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the radius of the smaller base of the frustum: ");
        double r2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the frustum: ");
        double h = Convert.ToDouble(Console.ReadLine());

        double area = CalculateFrustumArea(r1, r2, h);
        Console.WriteLine("The area of the frustum of the cone is: " + area);
    }
}
