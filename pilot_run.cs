
using System;

class Program
{
    static void Main()
    {
        double side1, side2, side3;

        // Get input for the three sides of the triangle
        Console.WriteLine("Enter the length of side 1: ");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 2: ");
        side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 3: ");
        side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the semi-perimeter of the triangle
        double semiPerimeter = (side1 + side2 + side3) / 2;

        // Calculate the area of the triangle using Heron's formula
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

        Console.WriteLine($"The area of the triangle is: {area}");
    }
}
