
using System;

class Program
{
    static double CalculateAreaOfHendecagon(double sideLength)
    {
        double area = (11 * sideLength * sideLength) / (4 * Math.Tan(Math.PI / 11));
        return area;
    }

    static void Main()
    {
        Console.Write("Enter the side length of the hendecagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double area = CalculateAreaOfHendecagon(sideLength);

        Console.WriteLine($"The area of the regular hendecagon with side length {sideLength} is: {area}");
    }
}
