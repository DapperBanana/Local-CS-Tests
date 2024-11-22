
using System;

class Program
{
    static void Main()
    {
        double baseArea, height, area;

        Console.WriteLine("Enter the base area of the pyramid: ");
        baseArea = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the height of the pyramid: ");
        height = Convert.ToDouble(Console.ReadLine());

        area = baseArea + (baseArea * Math.Sqrt(Math.Pow(height, 2) + Math.Pow(baseArea / 2, 2)));

        Console.WriteLine("The area of the pyramid is: " + area);
    }
}
