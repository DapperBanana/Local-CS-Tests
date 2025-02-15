
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the side length of the cube: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double surfaceArea = 6 * sideLength * sideLength;

        Console.WriteLine($"The surface area of the cube is {surfaceArea}");
    }
}
