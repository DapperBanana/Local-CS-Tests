
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        double area;
        
        // Input the side length of the tetrahedron
        Console.Write("Enter the side length of the tetrahedron: ");
        sideLength = double.Parse(Console.ReadLine());
        
        // Calculate the area of the tetrahedron
        area = Math.Sqrt(3) * Math.Pow(sideLength, 2);
        
        // Display the result
        Console.WriteLine("The area of the regular tetrahedron is: {0}", area);
    }
}
