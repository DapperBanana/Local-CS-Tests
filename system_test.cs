
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        double area;

        Console.Write("Enter the side length of the hexagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        area = (3 * Math.Sqrt(3) * Math.Pow(sideLength, 2)) / 2;

        Console.WriteLine($"The area of the regular hexagon is: {area}");
    }
}
