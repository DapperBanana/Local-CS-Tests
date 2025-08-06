
using System;

namespace ConeVolumeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, height;

            // Get the radius from the user
            Console.WriteLine("Enter the radius of the cone: ");
            radius = Convert.ToDouble(Console.ReadLine());

            // Get the height from the user
            Console.WriteLine("Enter the height of the cone: ");
            height = Convert.ToDouble(Console.ReadLine());

            // Calculate the volume of the cone
            double volume = (1.0/3.0) * Math.PI * Math.Pow(radius, 2) * height;

            // Display the volume of the cone
            Console.WriteLine($"The volume of the cone with radius {radius} and height {height} is: {volume}");
        }
    }
}
