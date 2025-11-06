
using System;

class Program
{
    static void Main()
    {
        int numSides = 16;
        double sideLength = 5;

        double area = CalculateArea(numSides, sideLength);
        Console.WriteLine($"The area of the regular hexadecagon is: {area}");
    }

    static double CalculateArea(int numSides, double sideLength)
    {
        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides));
        double perimeter = numSides * sideLength;
        double area = 0.5 * apothem * perimeter;
        return area;
    }
}
