
using System;

class Program
{
    static void Main()
    {
        int numSides = 12;
        double sideLength = 5.0;
        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides));
        
        double area = (numSides * sideLength * apothem) / 2;
        
        Console.WriteLine($"The area of a regular dodecagon with side length {sideLength} is {area}");
    }
}
