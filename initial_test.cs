
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the base area: ");
        double baseArea = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        
        double pyramidArea = (baseArea * 4) + (baseArea * height) / 2;
        
        Console.WriteLine($"The area of the pyramid is: {pyramidArea}");
    }
}
