
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the octagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double area = CalculateOctagonArea(sideLength);

        Console.WriteLine("The area of the regular octagon is: " + area);
    }

    static double CalculateOctagonArea(double sideLength)
    {
        double apothem = sideLength / (2 * Math.Tan(Math.PI / 8));
        double area = 2 * Math.Pow(sideLength, 2) * (1 + Math.Sqrt(2));

        return area;
    }
}
