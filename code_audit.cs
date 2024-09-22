
using System;

class Program
{
    static void Main()
    {
        double edgeLength;
        
        Console.WriteLine("Enter the edge length of the regular tetrahedron: ");
        edgeLength = Convert.ToDouble(Console.ReadLine());

        double area = Math.Sqrt(3) * Math.Pow(edgeLength, 2);
        
        Console.WriteLine($"The area of the regular tetrahedron is: {area}");
    }
}
