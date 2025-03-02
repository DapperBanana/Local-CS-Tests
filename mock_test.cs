
using System;

namespace HendecagonAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side length of the regular hendecagon:");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            double apothem = sideLength / (2 * Math.Tan(Math.PI / 11));
            double area = (11 * sideLength * apothem) / 2;

            Console.WriteLine($"The area of the regular hendecagon is: {area}");
        }
    }
}
