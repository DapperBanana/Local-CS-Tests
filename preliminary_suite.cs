
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        Console.Write("Enter the side length of the icosahedron: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        double area = 5 * Math.Sqrt(3) * Math.Pow(sideLength, 2);

        Console.WriteLine($"The area of the regular icosahedron is: {area}");
    }
}
