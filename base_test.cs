
using System;

class Program
{
    static void Main()
    {
        // Prompt user for the side length of the hendecagon
        Console.Write("Enter the side length of the hendecagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        // Calculate the apothem (distance from center to midpoint of a side)
        double apothem = sideLength / (2 * Math.Tan(Math.PI / 11));

        // Calculate the area of the hendecagon using the formula: Area = 0.5 * Perimeter * Apothem
        double area = 0.5 * 11 * sideLength * apothem;

        Console.WriteLine($"The area of the hendecagon is: {area}");
    }
}
