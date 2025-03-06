
using System;

class Program
{
    static void Main()
    {
        int numSides = 11;
        double sideLength = 5.0; // length of each side of the hendecagon

        double area = CalculateAreaOfHendecagon(numSides, sideLength);

        Console.WriteLine($"The area of the regular hendecagon is: {area}");
    }

    static double CalculateAreaOfHendecagon(int numSides, double sideLength)
    {
        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides));
        double perimeter = numSides * sideLength;
        double area = (perimeter * apothem) / 2;

        return area;
    }
}
