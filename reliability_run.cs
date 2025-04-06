
using System;

class Program
{
    static void Main()
    {
        int numSides = 16;
        double sideLength = 5.0;

        double area = CalculateHexadecagonArea(numSides, sideLength);

        Console.WriteLine($"The area of the regular hexadecagon is: {area}");
    }

    static double CalculateHexadecagonArea(int numSides, double sideLength)
    {
        double area = (numSides * Math.Pow(sideLength, 2)) / (4 * Math.Tan(Math.PI / numSides));
        return area;
    }
}
