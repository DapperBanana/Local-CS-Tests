
using System;

class Program
{
    static void Main()
    {
        double edgeLength, area;

        // Prompt user to enter the edge length of the icosahedron
        Console.Write("Enter the edge length of the icosahedron: ");
        edgeLength = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the icosahedron
        area = 5 * Math.Sqrt(3) * Math.Pow(edgeLength, 2);

        // Display the area of the icosahedron
        Console.WriteLine($"The area of the regular icosahedron with edge length {edgeLength} is {area}");
    }
}
