
using System;

class Program
{
    static void Main()
    {
        int sideLength = 5; // length of one side of the nonagon
        int numSides = 9; // number of sides in the nonagon

        double apothem = CalculateApothem(sideLength);
        double perimeter = sideLength * numSides;
        double area = 0.5 * apothem * perimeter;

        Console.WriteLine("The area of a regular nonagon with side length {0} is: {1}", sideLength, area);
    }

    static double CalculateApothem(int sideLength)
    {
        return sideLength / (2 * Math.Tan(Math.PI / 9));
    }
}
