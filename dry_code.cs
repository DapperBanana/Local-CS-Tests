
using System;

class Program
{
    static void Main()
    {
        int sides = 11;
        double sideLength = 5.0; // You can change this value to calculate for a hendecagon with different side length
        
        double apothem = sideLength / (2 * Math.Tan(Math.PI / sides));
        double area = 0.5 * apothem * sides * sideLength;

        Console.WriteLine($"The area of the regular hendecagon with side length {sideLength} is: {area}");
    }
}
