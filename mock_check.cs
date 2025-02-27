
using System;

class Program
{
    static void Main()
    {
        double edgeLength;
        Console.WriteLine("Enter the edge length of the icosahedron: ");
        edgeLength = double.Parse(Console.ReadLine());

        double area = CalculateIcosahedronArea(edgeLength);
        Console.WriteLine($"The area of the icosahedron is: {area}");
    }

    static double CalculateIcosahedronArea(double edgeLength)
    {
        double sideArea = 5 * Math.Sqrt(3) * Math.Pow(edgeLength, 2);
        double equilateralTriangleArea = (9 * Math.Sqrt(3) * Math.Pow(edgeLength, 2)) / 4;
        double totalArea = sideArea + (5 * equilateralTriangleArea);

        return totalArea;
    }
}
