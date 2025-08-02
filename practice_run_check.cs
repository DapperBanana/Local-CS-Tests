
using System;

class Program
{
    static void Main()
    {
        // Side length of the dodecagon
        double sideLength = 5;

        // Calculate the area of a regular dodecagon
        double apothem = sideLength * Math.Cos(Math.PI / 12);
        double area = 6 * sideLength * apothem;

        Console.WriteLine($"The area of the regular dodecagon is {area}");
    }
}
