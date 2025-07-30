
using System;

namespace SectorAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, angle, area;

            Console.WriteLine("Enter the radius of the sector:");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the angle of the sector in degrees:");
            angle = Convert.ToDouble(Console.ReadLine());

            // Convert angle from degrees to radians
            double angleRadians = angle * Math.PI / 180;

            // Calculate the area of the sector
            area = 0.5 * Math.Pow(radius, 2) * angleRadians;

            Console.WriteLine($"The area of the sector with radius {radius} and angle {angle} degrees is: {area}");
        }
    }
}
