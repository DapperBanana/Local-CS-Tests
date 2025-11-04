
using System;

class Program
{
    static void Main()
    {
        double sideLength, area;

        Console.Write("Enter the side length of the tetrahedron: ");
        sideLength = double.Parse(Console.ReadLine());

        area = Math.Sqrt(3) * Math.Pow(sideLength, 2);
        
        Console.WriteLine($"The area of the regular tetrahedron with side length {sideLength} is {area}");
    }
}
