
using System;

class TriangleAreaCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter the length of side a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double s = (a + b + c) / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        Console.WriteLine($"The area of the triangle is: {area}");
    }
}
