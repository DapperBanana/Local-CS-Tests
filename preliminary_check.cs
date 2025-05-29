
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the base area of the pyramid: ");
        double baseArea = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the height of the pyramid: ");
        double height = Convert.ToDouble(Console.ReadLine());
        
        double pyramidVolume = (baseArea * height) / 3;
        
        Console.WriteLine($"The area of the pyramid is: {pyramidVolume}");
    }
}
