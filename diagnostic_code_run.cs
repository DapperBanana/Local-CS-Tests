
using System;

class Program
{
    static void Main()
    {
        // User input for the length of the edge of the tetrahedron
        Console.Write("Enter the length of the edge of the regular tetrahedron: ");
        double edgeLength = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the regular tetrahedron
        double area = Math.Sqrt(3) * Math.Pow(edgeLength, 2);

        // Display the area of the regular tetrahedron
        Console.WriteLine($"The area of the regular tetrahedron is: {area}");
    }
}
