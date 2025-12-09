using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the side length of the hexadecagon
        Console.Write("Enter the length of one side of the regular hexadecagon: ");
        if (double.TryParse(Console.ReadLine(), out double sideLength) && sideLength > 0)
        {
            double area = CalculateHexadecagonArea(sideLength);
            Console.WriteLine($"The area of the regular hexadecagon is: {area}");
        }
        else
        {
            Console.WriteLine("Please enter a valid positive number for the side length.");
        }
    }

    static double CalculateHexadecagonArea(double side)
    {
        // Formula: (8 * s^2) / (2 - sqrt(2))
        double denominator = 2 - Math.Sqrt(2);
        return (8 * Math.Pow(side, 2)) / denominator;
    }
}