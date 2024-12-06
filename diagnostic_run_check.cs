
using System;

namespace HexadecagonAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side length of the regular hexadecagon: ");
            double sideLength = double.Parse(Console.ReadLine());

            double apothem = sideLength / (2 * Math.Tan(Math.PI / 16)); // Calculate apothem using the formula for a regular polygon
            double area = (16 * sideLength * apothem) / 2; // Calculate area using the formula for a regular polygon

            Console.WriteLine($"The area of the regular hexadecagon is: {area}");
        }
    }
}
