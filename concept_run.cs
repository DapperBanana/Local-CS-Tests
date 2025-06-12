
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        double height;

        Console.WriteLine("Enter the side length of the pentagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the prism: ");
        height = Convert.ToDouble(Console.ReadLine());

        double perimeter = 5 * sideLength;
        double apothem = sideLength / (2 * Math.Tan(Math.PI / 5));

        double baseArea = (perimeter * apothem) / 2;
        double lateralArea = perimeter * height;
        double totalArea = 2 * baseArea + lateralArea;

        Console.WriteLine($"The total surface area of the regular pentagonal prism is: {totalArea}");
    }
}
