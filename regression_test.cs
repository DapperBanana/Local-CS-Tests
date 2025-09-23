
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of sides of the regular polygon:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the length of each side:");
        double s = Convert.ToDouble(Console.ReadLine());

        double area = CalculateAreaOfRegularPolygon(n, s);

        Console.WriteLine($"The area of the regular polygon is {area}");
    }

    static double CalculateAreaOfRegularPolygon(int n, double s)
    {
        double area = (n * s * s) / (4 * Math.Tan(Math.PI / n));
        return area;
    }
}
