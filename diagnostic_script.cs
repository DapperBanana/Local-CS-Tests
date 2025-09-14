
using System;

class Program
{
    static void Main()
    {
        int numberOfSides = 9; // A nonagon has 9 sides
        double sideLength = 5.0; // Length of each side

        double apothem = sideLength / (2 * Math.Tan(Math.PI / numberOfSides));
        double area = (numberOfSides * sideLength * apothem) / 2;

        Console.WriteLine($"The area of the regular nonagon is: {area}");
    }
}
