
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of side A:");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side B:");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side C:");
        double sideC = Convert.ToDouble(Console.ReadLine());

        double semiPerimeter = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

        Console.WriteLine($"The area of the triangle is: {area}");
    }
}
