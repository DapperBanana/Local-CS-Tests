
using System;

class Program
{
    static void Main()
    {
        const int sides = 12; // Number of sides in a dodecagon
        double sideLength, apothem, area;

        // Input side length of the dodecagon
        Console.Write("Enter the side length of the dodecagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        // Calculate the apothem (distance from the center to the midpoint of a side)
        apothem = sideLength / (2 * Math.Tan(Math.PI / sides));

        // Calculate the area of the dodecagon using the formula: Area = 1/2 * Perimeter * Apothem
        area = 0.5 * sides * sideLength * apothem;

        Console.WriteLine($"The area of the dodecagon with side length {sideLength} is: {area}");
    }
}
