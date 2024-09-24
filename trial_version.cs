
using System;

namespace PyramidAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseArea, height;

            Console.WriteLine("Enter the base area of the pyramid: ");
            baseArea = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the pyramid: ");
            height = Convert.ToDouble(Console.ReadLine());

            double pyramidArea = (baseArea + (baseArea * Math.Sqrt(1 + Math.Pow((4 * height), 2)))) / 2;

            Console.WriteLine($"The area of the pyramid is: {pyramidArea}");
        }
    }
}
