
using System;

class Program
{
    static void Main()
    {
        int numOfSides = 9;
        double sideLength = 5.0;

        double area = CalculateArea(numOfSides, sideLength);
        
        Console.WriteLine("The area of the nonagon is: " + area);
    }

    static double CalculateArea(int numOfSides, double sideLength)
    {
        double apothem = sideLength / (2 * Math.Tan(Math.PI / numOfSides));
        double perimeter = sideLength * numOfSides;
        double area = 0.5 * perimeter * apothem;

        return area;
    }
}
