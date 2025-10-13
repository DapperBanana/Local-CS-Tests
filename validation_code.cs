
using System;

class Program
{
    static void Main()
    {
        int sides = 16;
        double radius;

        Console.WriteLine("Enter the radius of the hexadecagon:");
        radius = Convert.ToDouble(Console.ReadLine());

        double area = CalculateHexadecagonArea(sides, radius);
        Console.WriteLine("The area of the regular hexadecagon is: " + area);
    }

    static double CalculateHexadecagonArea(int sides, double radius)
    {
        return (sides * radius * radius * Math.Sin((2 * Math.PI) / sides)) / 2;
    }
}
