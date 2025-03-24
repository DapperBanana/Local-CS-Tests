
using System;

class Program
{
    static void Main()
    {
        int numberOfSides = 16;
        double sideLength = 5.0; // Assuming each side length is 5 units

        double apothem = sideLength / (2 * Math.Tan(Math.PI / numberOfSides));
        double area = 0.5 * numberOfSides * sideLength * apothem;

        Console.WriteLine("The area of the regular hexadecagon is: " + area);
    }
}
