
using System;

class Program
{
    static void Main()
    {
        double sideLength, apothem, height, baseArea, sideArea, totalArea;

        Console.WriteLine("Enter the side length of the pentagon:");
        sideLength = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the apothem length of the pentagon:");
        apothem = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the pentagonal prism:");
        height = double.Parse(Console.ReadLine());

        baseArea = 0.5 * 5 * sideLength * apothem;
        sideArea = 5 * sideLength * height;
        totalArea = 2 * baseArea + sideArea;

        Console.WriteLine("The total surface area of the pentagonal prism is: " + totalArea);
    }
}
