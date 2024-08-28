
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the pentagon:");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the prism:");
        double height = Convert.ToDouble(Console.ReadLine());

        double apothem = (sideLength / (2 * Math.Tan(Math.PI / 5)));
        double areaBase = (5 * sideLength * apothem) / 2;
        double areaSide = (5 * sideLength * height);
        double totalArea = (2 * areaBase) + areaSide;

        Console.WriteLine($"The area of the regular pentagonal prism is: {totalArea}");
    }
}
