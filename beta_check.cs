
using System;

class Program
{
    static void Main()
    {
        double edgeLength = 1; // You can change this to the desired length of the edge of the icosahedron
        double sideArea = 5 * Math.Sqrt(3) * Math.Pow(edgeLength, 2) / 4;
        double totalArea = sideArea * 20;

        Console.WriteLine($"The area of a regular icosahedron with edge length {edgeLength} is: {totalArea}");
    }
}
