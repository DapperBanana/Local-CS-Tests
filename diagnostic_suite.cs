
using System;

class Program
{
    static void Main()
    {
        double sideLength, apothem, area;

        Console.WriteLine("Enter the side length of the regular hexagon:");
        sideLength = double.Parse(Console.ReadLine());

        apothem = sideLength * Math.Sqrt(3) / 2;
        area = 3 * Math.Sqrt(3) * Math.Pow(sideLength, 2) / 2;

        Console.WriteLine("The area of the regular hexagon is: " + area);
    }
}
