
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the three sides of the triangle: ");
        double sideA = Convert.ToDouble(Console.ReadLine());
        double sideB = Convert.ToDouble(Console.ReadLine());
        double sideC = Convert.ToDouble(Console.ReadLine());

        double semiperimeter = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));

        Console.WriteLine($"The area of the triangle is: {area}");
    }
}
