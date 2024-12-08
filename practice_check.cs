
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the base area of the pyramid:");
        double baseArea = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the pyramid:");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = baseArea + 0.5 * (baseArea * 4 + Math.Sqrt(baseArea * 4) * Math.Sqrt(baseArea * 4 + 4 * height * height));

        Console.WriteLine("The area of the pyramid is: " + area);
    }
}
