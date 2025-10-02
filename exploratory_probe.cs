
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the side length of the octagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double area = 2 * (1 + Math.Sqrt(2)) * Math.Pow(sideLength, 2);

        Console.WriteLine($"The area of the regular octagon is: {area}");
    }
}
