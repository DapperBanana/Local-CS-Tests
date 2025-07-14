
using System;

class Program
{
    static void Main()
    {
        double baseArea, height, pyramidSurfaceArea;

        Console.WriteLine("Enter the base area of the pyramid: ");
        baseArea = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the pyramid: ");
        height = Convert.ToDouble(Console.ReadLine());

        // Calculate the surface area of the pyramid
        pyramidSurfaceArea = baseArea + 0.5 * (4 * Math.Sqrt((height * height) + ((baseArea * baseArea) / 4)));

        Console.WriteLine($"The surface area of the pyramid is: {pyramidSurfaceArea}");
    }
}
