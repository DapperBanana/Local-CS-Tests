
using System;

class Program
{
    static void Main()
    {
        // Input the side length of the tetrahedron
        Console.Write("Enter the side length of the regular tetrahedron: ");
        double sideLength = double.Parse(Console.ReadLine());

        // Calculate the area of the tetrahedron
        double area = Math.Sqrt(3) * Math.Pow(sideLength, 2);

        // Print the result
        Console.WriteLine($"The area of the regular tetrahedron is: {area}");
    }
}
