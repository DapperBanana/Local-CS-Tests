
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the base area of the pyramid: ");
        double baseArea = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the pyramid: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double pyramidArea = (baseArea + (2 * Math.Sqrt(baseArea * baseArea + 4 * height * height)));

        Console.WriteLine($"The area of the pyramid is: {pyramidArea}");
    }
}
