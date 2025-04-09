
using System;

class Program
{
    static double CalculateAreaOfHexadecagon(double sideLength)
    {
        return (8 * sideLength * sideLength) / (4 * Math.Tan(Math.PI / 16));
    }

    static void Main()
    {
        double sideLength;

        Console.Write("Enter the side length of the regular hexadecagon: ");
        if (!double.TryParse(Console.ReadLine(), out sideLength) || sideLength <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            return;
        }

        double area = CalculateAreaOfHexadecagon(sideLength);
        Console.WriteLine($"The area of the regular hexadecagon is: {area}");
    }
}
