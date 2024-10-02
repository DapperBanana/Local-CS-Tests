
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of sides of the regular polygon:");
        int sides = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of each side:");
        double sideLength = double.Parse(Console.ReadLine());

        double area = CalculateArea(sides, sideLength);

        Console.WriteLine($"The area of the regular polygon is: {area}");
    }

    static double CalculateArea(int sides, double sideLength)
    {
        double apothem = sideLength / (2 * Math.Tan(Math.PI / sides));
        double perimeter = sides * sideLength;
        double area = 0.5 * apothem * perimeter;
        
        return area;
    }
}
