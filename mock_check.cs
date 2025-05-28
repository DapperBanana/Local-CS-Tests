
using System;

namespace ConeVolumeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get cone radius from user
            Console.Write("Enter the radius of the cone: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            // Get cone height from user
            Console.Write("Enter the height of the cone: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calculate cone volume
            double volume = (Math.PI * Math.Pow(radius, 2) * height) / 3;

            // Display the result
            Console.WriteLine($"The volume of the cone with radius {radius} and height {height} is {volume} cubic units.");
        }
    }
}
