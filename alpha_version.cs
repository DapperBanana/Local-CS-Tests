
using System;

namespace PentagonalPrismAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side length of the pentagon:");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the prism:");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 5 * sideLength * height + 5 * (sideLength * sideLength) / 2 * Math.Tan(Math.PI/5);

            Console.WriteLine($"The area of the regular pentagonal prism is: {area}");
        }
    }
}
