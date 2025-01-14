
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        
        Console.WriteLine("Enter the side length of the octagon:");
        sideLength = Convert.ToDouble(Console.ReadLine());

        double area = CalculateOctagonArea(sideLength);
        
        Console.WriteLine($"The area of the octagon is: {area}");
    }

    static double CalculateOctagonArea(double sideLength)
    {
        double apothem = sideLength / (2 * Math.Tan(Math.PI / 8));
        double area = (4 * apothem * sideLength);
        return area;
    }
}
