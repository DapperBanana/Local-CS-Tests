
using System;

class Program
{
    static void Main()
    {
        int n = 9; // number of sides (nonagon)
        double s; // length of each side

        Console.Write("Enter the length of each side of the nonagon: ");
        s = Convert.ToDouble(Console.ReadLine());

        double area = CalculateArea(n, s);
        Console.WriteLine($"The area of the regular nonagon is: {area}");
    }

    static double CalculateArea(int n, double s)
    {
        double angle = Math.PI / n; // angle in radians
        double cot = 1 / Math.Tan(angle); // cotangent of the angle

        double area = 1.5 * n * Math.Pow(s, 2) * cot;
        return area;
    }
}
