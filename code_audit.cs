
using System;

class Program
{
    static void Main()
    {
        int numSides = 9;
        Console.WriteLine("Enter the length of one side of the nonagon:");
        double sideLength = double.Parse(Console.ReadLine());

        double area = numSides * Math.Pow(sideLength, 2) / (4 * Math.Tan(Math.PI / numSides));

        Console.WriteLine($"The area of the nonagon is: {area}");
    }
}
