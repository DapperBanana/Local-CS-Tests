
using System;

class Program
{
    static void Main()
    {
        double sideLength, height;
        
        Console.WriteLine("Enter the side length of the pentagon:");
        sideLength = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the height of the prism:");
        height = Convert.ToDouble(Console.ReadLine());
        
        double apothem = sideLength / (2 * Math.Tan(Math.PI / 5)); // Calculate the apothem
        double perimeter = 5 * sideLength; // Calculate the perimeter of the base
        double baseArea = (perimeter * apothem) / 2; // Calculate the area of the base

        double lateralSurfaceArea = perimeter * height; // Calculate the lateral surface area
        double totalSurfaceArea = (baseArea * 2) + lateralSurfaceArea; // Calculate the total surface area

        Console.WriteLine($"The area of the regular pentagonal prism is {totalSurfaceArea}");
    }
}
