
using System;

class Program
{
    static void Main()
    {
        const int numSides = 11;
        const double sideLength = 5.0;

        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides));
        double area = 0.5 * numSides * sideLength * apothem;

        Console.WriteLine("Area of the regular hendecagon: {0}", area);
    }
}
