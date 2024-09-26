
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        double area;

        Console.Write("Enter the side length of the tetrahedron: ");
        sideLength = double.Parse(Console.ReadLine());

        area = Math.Sqrt(3) * sideLength * sideLength;
        
        Console.WriteLine("The area of the regular tetrahedron is: {0}", area);
    }
}
