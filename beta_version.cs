
using System;

class Program
{
    static void Main()
    {
        int numSides = 9; // Nonagon has 9 sides
        double sideLength = 5; // Length of each side of the nonagon
        
        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides)); // Calculate apothem using formula
        double perimeter = numSides * sideLength; // Calculate perimeter
        double area = 0.5 * apothem * perimeter; // Calculate area of the nonagon

        Console.WriteLine($"Area of the nonagon with side length {sideLength} is {area}");
    }
}
