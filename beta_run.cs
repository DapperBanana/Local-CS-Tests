
using System;

class Program
{
    static void Main()
    {
        double sideLength, area;

        Console.WriteLine("Enter the side length of the regular tetrahedron: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        area = Math.Pow(sideLength, 2) * Math.Sqrt(3);

        Console.WriteLine("The area of the regular tetrahedron is: " + area);
    }
}
