
using System;

class Program
{
    static void Main()
    {
        int sides = 11;
        double sideLength = 5;

        double apothem = sideLength / (2 * Math.Tan(Math.PI / sides));
        double perimeter = sides * sideLength;
        double area = 0.5 * apothem * perimeter;

        Console.WriteLine($"The area of a regular hendecagon with side length {sideLength} is: {area}");
    }
}
