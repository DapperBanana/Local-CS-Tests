
using System;

class Program
{
    static void Main()
    {
        double sideLength, apothem, height;

        Console.WriteLine("Enter the side length of the pentagon:");
        sideLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the apothem (distance from the center to the middle of a side) of the pentagon:");
        apothem = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the prism:");
        height = Convert.ToDouble(Console.ReadLine());

        double baseArea = 5 * sideLength * apothem / 2; // Area of the pentagon base
        double sideArea = 5 * sideLength * height; // Area of the sides of the prism

        double totalArea = 2 * baseArea + sideArea; // Total surface area of the prism

        Console.WriteLine("The area of the regular pentagonal prism is: " + totalArea);
    }
}
