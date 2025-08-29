
using System;

class Program
{
    static void Main()
    {
        const int numSides = 16;
        double sideLength;

        Console.Write("Enter the side length of the regular hexadecagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides));
        double area = 0.5 * numSides * sideLength * apothem;

        Console.WriteLine("The area of the regular hexadecagon is: " + area);
    }
}
