
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle: ");
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());

        double s = (side1 + side2 + side3) / 2;

        double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

        Console.WriteLine($"The area of the triangle is: {area}");
    }
}
