using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the length of one side of the hexadecagon
        Console.Write("Enter the length of one side of the hexadecagon: ");
        double sideLength;
        if (double.TryParse(Console.ReadLine(), out sideLength) && sideLength > 0)
        {
            double area = CalculateHexadecagonArea(sideLength);
            Console.WriteLine($"The area of the hexadecagon is: {area}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }

    static double CalculateHexadecagonArea(double side)
    {
        // Formula for the area of a regular n-gon:
        // Area = (1/4) * n * s^2 * cot(pi/n)
        int n = 16;
        double piOverN = Math.PI / n;
        double cotPiOverN = 1.0 / Math.Tan(piOverN);
        double area = (n * side * side * cotPiOverN) / 4.0;
        return area;
    }
}