
using System;

class Program
{
    static void Main()
    {
        double sideLength, apothem, height;

        Console.WriteLine("Enter the side length of the pentagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the apothem of the pentagon: ");
        apothem = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the prism: ");
        height = Convert.ToDouble(Console.ReadLine());

        double baseArea = 5 * sideLength * apothem / 2;
        double lateralArea = 5 * sideLength * height;
        double totalArea = baseArea + lateralArea;

        Console.WriteLine("The area of the regular pentagonal prism is: " + totalArea);
    }
}
