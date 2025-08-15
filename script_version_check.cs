
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the three sides of the triangle:");
        
        Console.Write("Side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());
        
        double perimeter = (side1 + side2 + side3) / 2;
        double area = Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
        
        Console.WriteLine($"The area of the triangle is: {area}");
    }
}
