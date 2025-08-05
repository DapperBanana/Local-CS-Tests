
using System;

class Program
{
    static void Main()
    {
        double sideLength, height;

        Console.WriteLine("Enter the side length of the regular pentagon: ");
        sideLength = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the prism: ");
        height = double.Parse(Console.ReadLine());

        double apothem = Math.Sqrt(1 - Math.Pow(0.5, 2)) * sideLength; // apothem of the pentagon

        double baseArea = 5 * 0.5 * sideLength * apothem; // area of the base pentagon
        double lateralArea = 5 * sideLength * height; // lateral area of the prism

        double totalArea = baseArea + lateralArea; // total surface area of the prism

        Console.WriteLine("The total surface area of the regular pentagonal prism is: " + totalArea);
    }
}
