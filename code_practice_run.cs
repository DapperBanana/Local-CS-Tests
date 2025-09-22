
using System;

namespace PyramidAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pyramid Area Calculator!");

            // Get user input for base area and height
            Console.Write("Enter the base area of the pyramid: ");
            double baseArea = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the pyramid: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calculate the area of the pyramid
            double pyramidArea = (baseArea + baseArea) + (0.5 * (baseArea * height));

            Console.WriteLine($"The area of the pyramid is: {pyramidArea}");
        }
    }
}
