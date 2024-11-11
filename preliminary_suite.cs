
using System;

class Program
{
    static void Main()
    {
        int numberOfSides = 11;
        double sideLength;

        Console.Write("Enter the length of a side of the hendecagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        double area = numberOfSides * Math.Pow(sideLength, 2) / (4 * Math.Tan(Math.PI / numberOfSides));

        Console.WriteLine("The area of the hendecagon is: " + area);
    }
}
