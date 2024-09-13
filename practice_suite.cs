
using System;

class Program
{
    static void Main()
    {
        double edgeLength;

        Console.WriteLine("Enter the edge length of the tetrahedron:");
        if (!double.TryParse(Console.ReadLine(), out edgeLength) || edgeLength <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            return;
        }

        double area = Math.Sqrt(3) * Math.Pow(edgeLength, 2);
        Console.WriteLine($"The area of the regular tetrahedron with edge length {edgeLength} is {area:F2}");
    }
}
