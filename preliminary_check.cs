
using System;

class Program
{
    static void Main()
    {
        int sides = 11;
        double sideLength = 5.0; // Assuming side length is 5 units
        double apothem = sideLength / (2 * Math.Tan(Math.PI / sides));
        
        double area = sides * sideLength * apothem / 2;
        
        Console.WriteLine($"The area of a regular hendecagon with side length {sideLength} units is {area} square units.");
    }
}
