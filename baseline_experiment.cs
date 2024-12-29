
using System;

namespace PentagonalPrismAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideLength;
            double height;

            Console.WriteLine("Enter the side length of the pentagon:");
            sideLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the prism:");
            height = double.Parse(Console.ReadLine());

            double baseArea = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * sideLength * sideLength;
            double lateralArea = 5 * sideLength * height;
            double totalArea = 2 * baseArea + lateralArea;

            Console.WriteLine($"The area of the pentagonal prism is: {totalArea}");
        }
    }
}
