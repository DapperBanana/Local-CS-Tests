
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the pentagon base: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the prism: ");
        double prismHeight = Convert.ToDouble(Console.ReadLine());

        double apothemLength = sideLength / (2 * Math.Tan(Math.PI / 5));
        double baseArea = (5 * sideLength * apothemLength) / 2;
        double lateralArea = 5 * sideLength * prismHeight;
        double totalArea = baseArea + lateralArea;

        Console.WriteLine("The area of the regular pentagonal prism is: " + totalArea);
    }
}
