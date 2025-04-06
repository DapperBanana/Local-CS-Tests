
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

            double slantHeight = Math.Sqrt(Math.Pow(baseArea / 2, 2) + Math.Pow(height, 2));
            double lateralArea = baseArea + (baseArea / 2) * slantHeight;

            Console.WriteLine("The area of the pyramid is: " + lateralArea);
        }
    }
}
