
using System;

class Program
{
    static void Main()
    {
        double sideLength, height;
        
        Console.WriteLine("Enter the side length of the pentagon: ");
        sideLength = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the height of the prism: ");
        height = double.Parse(Console.ReadLine());
        
        double perimeter = 5 * sideLength;
        double apothem = sideLength / (2 * Math.Tan(Math.PI / 5));
        double baseArea = 0.5 * perimeter * apothem;
        double lateralArea = perimeter * height;
        double totalArea = 2 * baseArea + lateralArea;
        
        Console.WriteLine("The area of the regular pentagonal prism is: " + totalArea);
    }
}
