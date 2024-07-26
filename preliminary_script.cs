
using System;

class Icosahedron
{
    static void Main()
    {
        // Define the edge length of the icosahedron
        double edgeLength = 5.0;

        // Calculate the area of one equilateral triangle on the icosahedron
        double triangleArea = Math.Sqrt(3) * Math.Pow(edgeLength, 2) / 4;

        // Calculate the total surface area of the icosahedron (20 equilateral triangles)
        double totalArea = 20 * triangleArea;

        Console.WriteLine("The total surface area of the icosahedron with edge length {0} is: {1}", edgeLength, totalArea);
    }
}
