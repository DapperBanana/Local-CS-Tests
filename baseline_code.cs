
using System;

class Program
{
    static void Main()
    {
        double baseArea, height;

        Console.WriteLine("Enter the base area of the pyramid: ");
        baseArea = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the pyramid: ");
        height = Convert.ToDouble(Console.ReadLine());

        double sideArea = Math.Sqrt(baseArea * baseArea + height * height);

        double surfaceArea = baseArea + (baseArea * sideArea) / 2;

        Console.WriteLine("The surface area of the pyramid is: " + surfaceArea);
    }
}
