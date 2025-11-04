
using System;

class Program
{
    static void Main()
    {
        double side1, side2, side3;

        Console.WriteLine("Enter the length of side 1: ");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 2: ");
        side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 3: ");
        side3 = Convert.ToDouble(Console.ReadLine());

        double semiperimeter = (side1 + side2 + side3) / 2;

        double area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));

        Console.WriteLine($"The area of the triangle is: {area}");
    }
}
