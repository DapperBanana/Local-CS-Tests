
using System;

class Program
{
    static void Main()
    {
        int numberOfSides = 16;
        double sideLength = 5.0; // assuming a side length of 5 units
        
        double apothem = sideLength / (2 * Math.Tan(Math.PI / numberOfSides));
        double area = (numberOfSides * sideLength * apothem) / 2;

        Console.WriteLine("Area of the regular hexadecagon: " + area);
    }
}
