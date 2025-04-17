
using System;

namespace PyramidAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Enter the base area of the pyramid: ");
            double baseArea = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the pyramid: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calculate the area of the pyramid
            double area = 0.33333 * baseArea * height;

            // Display the result
            Console.WriteLine("The area of the pyramid is: " + area);
        }
    }
}
