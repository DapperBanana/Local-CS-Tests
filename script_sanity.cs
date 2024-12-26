
using System;

class Program
{
    static void Main()
    {
        double baseArea, height, pyramidArea;
        
        Console.WriteLine("Enter the base area of the pyramid: ");
        baseArea = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the pyramid: ");
        height = double.Parse(Console.ReadLine());

        pyramidArea = (baseArea + (baseArea * Math.Sqrt(1 + Math.Pow((4 * height), 2)))) / 2;

        Console.WriteLine($"The area of the pyramid is: {pyramidArea}");
    }
}
