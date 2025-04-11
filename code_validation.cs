
using System;

class Program
{
    static void Main()
    {
        double edgeLength = 5; // length of each edge of the icosahedron

        double phi = (1 + Math.Sqrt(5)) / 2; // golden ratio

        double area = 5 * Math.Sqrt(3) * Math.Pow(edgeLength, 2) * phi;

        Console.WriteLine("The area of the regular icosahedron is: " + area);
    }
}
