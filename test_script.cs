
using System;

class Program
{
    static void Main()
    {
        double baseArea, height, pyramidArea;

        Console.WriteLine("Enter the base area of the pyramid: ");
        baseArea = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the pyramid: ");
        height = Convert.ToDouble(Console.ReadLine());

        pyramidArea = baseArea + 4 * (baseArea * height) / 2;

        Console.WriteLine($"The area of the pyramid is: {pyramidArea}");
    }
}
