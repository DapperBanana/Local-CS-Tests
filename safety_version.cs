
using System;

class Program
{
    static void Main()
    {
        double sideLength, height;

        Console.Write("Enter the side length of the pentagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the prism: ");
        height = Convert.ToDouble(Console.ReadLine());

        double baseArea = 5 * sideLength * sideLength * Math.Tan(Math.PI / 5) / 4;
        double lateralArea = 5 * sideLength * height;
        double totalArea = 2 * baseArea + lateralArea;

        Console.WriteLine("The total surface area of the pentagonal prism is: " + totalArea);
    }
}
