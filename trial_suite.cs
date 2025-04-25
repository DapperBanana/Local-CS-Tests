
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of sides of the regular polygon:");
        int numSides = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of each side:");
        double sideLength = double.Parse(Console.ReadLine());

        double area = CalculateArea(numSides, sideLength);

        Console.WriteLine($"The area of the regular polygon is: {area}");
        
        Console.ReadLine();
    }

    static double CalculateArea(int numSides, double sideLength)
    {
        return (numSides * Math.Pow(sideLength, 2)) / (4 * Math.Tan(Math.PI / numSides));
    }
}
