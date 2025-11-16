
using System;

class Program
{
    static void Main()
    {
        int numSides = 11;
        double sideLength;
        
        Console.WriteLine("Enter the length of a side of the hendecagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides));
        double area = (numSides * sideLength * apothem) / 2;

        Console.WriteLine($"The area of the hendecagon is: {area}");
    }
}
