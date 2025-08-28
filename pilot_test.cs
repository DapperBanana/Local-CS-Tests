
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        double area;

        Console.Write("Enter the side length of the hexagon: ");
        sideLength = double.Parse(Console.ReadLine());

        // Calculate the area of the regular hexagon
        area = (3 * Math.Sqrt(3) / 2) * Math.Pow(sideLength, 2);

        Console.WriteLine($"The area of the regular hexagon is: {area}");
    }
}
