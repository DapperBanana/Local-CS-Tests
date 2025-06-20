
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the cube: ");
        double sideLength = double.Parse(Console.ReadLine());

        double surfaceArea = 6 * Math.Pow(sideLength, 2);

        Console.WriteLine("The surface area of the cube is: " + surfaceArea);
    }
}
