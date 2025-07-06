
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the regular tetrahedron:");
        double sideLength = double.Parse(Console.ReadLine());

        double area = Math.Sqrt(3) * sideLength * sideLength;
        
        Console.WriteLine($"The area of the regular tetrahedron is: {area}");
    }
}
