
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        
        Console.Write("Enter the side length of the tetrahedron: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        double area = Math.Sqrt(3) * sideLength * sideLength;
        Console.WriteLine("The area of the regular tetrahedron is: " + area);
    }
}
