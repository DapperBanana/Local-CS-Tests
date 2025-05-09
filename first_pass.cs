
using System;

namespace PyramidAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseArea, height;
            double area;

            Console.WriteLine("Enter the base area of the pyramid: ");
            baseArea = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the pyramid: ");
            height = double.Parse(Console.ReadLine());

            area = baseArea + (0.5 * height);
            Console.WriteLine("The area of the pyramid is: " + area);
        }
    }
}
