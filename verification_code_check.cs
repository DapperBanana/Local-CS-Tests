
using System;

class Program
{
    static void Main()
    {
        double sideLength, area;

        Console.WriteLine("Enter the side length of the icosahedron: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        area = 5 * Math.Sqrt(3) * sideLength * sideLength;

        Console.WriteLine("The surface area of the regular icosahedron is: " + area);
    }
}
