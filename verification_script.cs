
using System;

class Program
{
    static void Main()
    {
        double sideLength, height;

        Console.WriteLine("Enter the side length of the pentagon:");
        sideLength = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the prism:");
        height = double.Parse(Console.ReadLine());

        double area = CalculateArea(sideLength, height);
        
        Console.WriteLine($"The area of the regular pentagonal prism is: {area}");
    }

    static double CalculateArea(double sideLength, double height)
    {
        double perimeter = 5 * sideLength;
        double apothem = sideLength / (2.0 * Math.Tan(Math.PI / 5.0));
        double baseArea = (perimeter * apothem) / 2.0;
        double lateralArea = perimeter * height;

        return 2 * baseArea + lateralArea;
    }
}
