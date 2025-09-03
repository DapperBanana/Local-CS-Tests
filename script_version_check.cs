
using System;

class Program
{
    static void Main()
    {
        double baseArea, height;
        
        Console.WriteLine("Enter the base area of the pyramid: ");
        baseArea = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the height of the pyramid: ");
        height = double.Parse(Console.ReadLine());
        
        double pyramidArea = (baseArea + baseArea + Math.Sqrt(baseArea * baseArea + 4 * baseArea * height)) / 2;
        
        Console.WriteLine($"The area of the pyramid is: {pyramidArea}");
    }
}
