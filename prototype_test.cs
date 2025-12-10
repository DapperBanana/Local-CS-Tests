using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of an edge of the regular tetrahedron:");
        double edgeLength;
        if (double.TryParse(Console.ReadLine(), out edgeLength) && edgeLength > 0)
        {
            double volume = CalculateTetrahedronArea(edgeLength);
            Console.WriteLine($"The surface area of the regular tetrahedron is: {volume:F2}");
        }
        else
        {
            Console.WriteLine("Please enter a valid positive number for the edge length.");
        }
    }

    static double CalculateTetrahedronArea(double edge)
    {
        // Surface area of a regular tetrahedron: A = sqrt(3) * a^2
        return Math.Sqrt(3) * Math.Pow(edge, 2);
    }
}