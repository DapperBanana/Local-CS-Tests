
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the side length of the pentagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double apothem = sideLength / (2 * Math.Tan(Math.PI / 5));
        double area = 0.5 * (5 * sideLength * apothem);

        Console.WriteLine($"The area of the pentagon is {area}");
    }
}
