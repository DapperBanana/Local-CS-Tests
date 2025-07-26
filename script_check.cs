
using System;

class Cube
{
    static void Main()
    {
        double sideLength, surfaceArea;

        Console.WriteLine("Enter the side length of the cube: ");
        sideLength = double.Parse(Console.ReadLine());

        surfaceArea = 6 * sideLength * sideLength;

        Console.WriteLine("Surface Area of the cube is: " + surfaceArea);
    }
}
