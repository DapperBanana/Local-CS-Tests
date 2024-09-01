
using System;

class Program
{
    static void Main()
    {
        int sideLength = 5; // length of each side of the hexadecagon
        int numberOfSides = 16; // total number of sides in a hexadecagon

        double area = CalculateHexadecagonArea(sideLength, numberOfSides);
        Console.WriteLine($"The area of the regular hexadecagon is: {area}");
    }

    static double CalculateHexadecagonArea(int sideLength, int numberOfSides)
    {
        double apothem = sideLength / (2 * Math.Tan(Math.PI / numberOfSides));
        double perimeter = sideLength * numberOfSides;
        double area = 0.5 * apothem * perimeter;

        return area;
    }
}
