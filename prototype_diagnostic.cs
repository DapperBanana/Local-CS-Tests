
using System;

class Program
{
    static void Main()
    {
        double sideLength, height;

        Console.WriteLine("Enter the side length of the pentagon:");
        sideLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the pentagon:");
        height = Convert.ToDouble(Console.ReadLine());

        double area = CalculatePentagonalPrismArea(sideLength, height);

        Console.WriteLine($"The area of the regular pentagonal prism is: {area}");
    }

    static double CalculatePentagonalPrismArea(double sideLength, double height)
    {
        double perimeter = 5 * sideLength;
        double apothem = sideLength / (2 * Math.Tan(Math.PI / 5));

        double baseArea = 0.5 * perimeter * apothem;
        double lateralArea = 5 * sideLength * height;
        double totalArea = (2 * baseArea) + lateralArea;

        return totalArea;
    }
}
