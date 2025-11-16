
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the hendecagon:");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double apothem = sideLength / (2 * Math.Tan(Math.PI / 11)); // Calculate apothem using the formula for a regular hendecagon
        double area = (11 * sideLength * apothem) / 2; // Calculate the area using the formula: area = 1/2 * perimeter * apothem

        Console.WriteLine($"The area of the regular hendecagon is: {area}");
    }
}
