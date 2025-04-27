
using System;

class Program
{
    static void Main()
    {
        int numOfSides = 11;
        Console.WriteLine("Please enter the side length of the hendecagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double area = CalculateArea(numOfSides, sideLength);
        Console.WriteLine($"The area of the hendecagon is: {area}");
    }

    static double CalculateArea(int numOfSides, double sideLength)
    {
        double perimeter = numOfSides * sideLength;
        double apothem = sideLength / (2 * Math.Tan(Math.PI / numOfSides));
        double area = 0.5 * perimeter * apothem;
        return area;
    }
}
