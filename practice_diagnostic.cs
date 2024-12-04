
using System;

class Program
{
    static void Main()
    {
        int sideLength = 5; // Assuming the side length is 5 units
        int numSides = 9; // A nonagon has 9 sides

        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides)); // Calculate the apothem using the formula
        double perimeter = sideLength * numSides; // Calculate the perimeter of the nonagon
        double area = 0.5 * apothem * perimeter; // Calculate the area of the nonagon

        Console.WriteLine($"The area of the regular nonagon is: {area} square units");
    }
}
