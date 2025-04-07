
using System;

class Program
{
    static void Main()
    {
        double sideLength, nSides, apothem, area;

        // Input the length of a side of the polygon
        Console.Write("Enter the length of a side of the polygon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        // Input the number of sides of the polygon
        Console.Write("Enter the number of sides of the polygon: ");
        nSides = Convert.ToDouble(Console.ReadLine());

        // Calculate the apothem (distance from center of polygon to midpoint of side)
        apothem = sideLength / (2 * Math.Tan(Math.PI / nSides));

        // Calculate the area of the polygon
        area = (nSides * sideLength * apothem) / 2;

        Console.WriteLine($"The area of the regular polygon is {area}");
    }
}
