
using System;

class Program
{
    static void Main()
    {
        double edgeLength, sideArea, baseArea, totalArea;

        Console.Write("Enter the edge length of the icosahedron: ");
        edgeLength = Convert.ToDouble(Console.ReadLine());

        sideArea = 5 * Math.Sqrt(3) * Math.Pow(edgeLength, 2);
        baseArea = 5 * Math.Sqrt(3) * Math.Pow(edgeLength, 2) / 4;
        totalArea = sideArea + baseArea;

        Console.WriteLine("The area of the regular icosahedron with edge length {0} is {1}", edgeLength, totalArea);
    }
}
