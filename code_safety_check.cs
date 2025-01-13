
using System;

namespace PyramidAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseArea;
            double height;

            Console.WriteLine("Enter the base area of the pyramid: ");
            baseArea = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the pyramid: ");
            height = Convert.ToDouble(Console.ReadLine());

            double pyramidArea = baseArea + 0.5 * baseArea * (2 * Math.Sqrt(Math.Pow(height, 2) + Math.Pow(baseArea / 2, 2)));

            Console.WriteLine("The area of the pyramid is: " + pyramidArea);
        }
    }
}
