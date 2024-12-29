
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the base area of the pyramid:");
        double baseArea = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the pyramid:");
        double height = double.Parse(Console.ReadLine());

        double pyramidArea = baseArea + 2 * (baseArea * Math.Sqrt((Math.Pow(2, height) - Math.Pow(baseArea / 2, 2))));

        Console.WriteLine($"The area of the pyramid is: {pyramidArea}");
    }
}
