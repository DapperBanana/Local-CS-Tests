
using System;

namespace PentagonalPrismAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double apothem, sideLength, height;

            Console.WriteLine("Enter the apothem length of the pentagon:");
            apothem = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the side length of the pentagon:");
            sideLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the prism:");
            height = Convert.ToDouble(Console.ReadLine());

            double baseArea = 5 * apothem * sideLength / 2;
            double lateralArea = 5 * sideLength * height;
            double totalArea = baseArea + lateralArea;

            Console.WriteLine($"The area of the regular pentagonal prism is: {totalArea}");
        }
    }
}
