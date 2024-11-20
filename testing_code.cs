
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter side 1 of the triangle: ");
        double side1 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter side 2 of the triangle: ");
        double side2 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter side 3 of the triangle: ");
        double side3 = double.Parse(Console.ReadLine());
        
        double semiPerimeter = (side1 + side2 + side3) / 2;
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        
        Console.WriteLine($"The area of the triangle is: {area}");
    }
}
