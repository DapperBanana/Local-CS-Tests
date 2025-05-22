
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        const int numSides = 12;

        Console.WriteLine("Enter the length of one side of the dodecagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides));
        double area = 0.5 * numSides * sideLength * apothem;

        Console.WriteLine("The area of the regular dodecagon is: " + area);
    }
}
