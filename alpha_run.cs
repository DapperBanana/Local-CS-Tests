
using System;

namespace AreaOfParallelogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseLength, height, area;

            Console.WriteLine("Enter the base length of the parallelogram: ");
            baseLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the parallelogram: ");
            height = Convert.ToDouble(Console.ReadLine());

            area = baseLength * height;

            Console.WriteLine("The area of the parallelogram is: " + area);
        }
    }
}
