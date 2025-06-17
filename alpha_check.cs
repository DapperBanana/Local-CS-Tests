
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

            double volume = (baseArea * height) / 3;
            Console.WriteLine("The volume of the pyramid is: " + volume);
        }
    }
}
