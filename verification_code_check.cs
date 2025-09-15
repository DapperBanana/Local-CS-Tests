
using System;

class TriangleAreaCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter the three sides of the triangle:");
        
        Console.Write("Side A: ");
        double sideA = double.Parse(Console.ReadLine());
        
        Console.Write("Side B: ");
        double sideB = double.Parse(Console.ReadLine());
        
        Console.Write("Side C: ");
        double sideC = double.Parse(Console.ReadLine());
        
        double semiPerimeter = (sideA + sideB + sideC) / 2;
        
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        
        Console.WriteLine($"The area of the triangle is: {area}");
    }
}
