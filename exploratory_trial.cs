
using System;

class Program
{
    static void Main()
    {
        double sideA, sideB, sideC;

        Console.WriteLine("Enter the length of side A:");
        sideA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side B:");
        sideB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side C:");
        sideC = Convert.ToDouble(Console.ReadLine());

        double semiPerimeter = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

        Console.WriteLine($"The area of the triangle is: {area}");
    }
}
