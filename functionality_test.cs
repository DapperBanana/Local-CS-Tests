
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the side length of the nonagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        // Calculate the internal angle of the regular nonagon
        double internalAngle = 360.0 / 9;

        // Calculate the apothem (distance from the center to the midpoint of a side)
        double apothem = sideLength / (2 * Math.Tan(Math.PI / 9));

        // Calculate the area of the regular nonagon
        double area = (9 * sideLength * apothem) / 2;

        Console.WriteLine($"The area of the regular nonagon is: {area}");
    }
}
