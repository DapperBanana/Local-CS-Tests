
using System;

namespace PyramidAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseArea, height, pyramidArea;

            Console.WriteLine("Enter the base area of the pyramid: ");
            baseArea = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the pyramid: ");
            height = Convert.ToDouble(Console.ReadLine());

            pyramidArea = (baseArea + (2 * Math.Sqrt(baseArea) * Math.Sqrt((baseArea / 4) + (height * height)));

            Console.WriteLine("The area of the pyramid is: " + pyramidArea);
        }
    }
}

