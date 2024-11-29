
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        double area;

        // Input the side length of the tetrahedron
        Console.Write("Enter the side length of the regular tetrahedron: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the tetrahedron
        area = Math.Sqrt(3) * Math.Pow(sideLength, 2);

        // Display the area of the tetrahedron
        Console.WriteLine($"The area of the regular tetrahedron is: {area}");
    }
}
