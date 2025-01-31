
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        
        Console.WriteLine("Enter the side length of the cube: ");
        sideLength = Convert.ToDouble(Console.ReadLine());
        
        double surfaceArea = 6 * Math.Pow(sideLength, 2);
        
        Console.WriteLine("The surface area of the cube is: " + surfaceArea);
    }
}
