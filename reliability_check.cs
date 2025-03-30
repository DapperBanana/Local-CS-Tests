
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the nonagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        int numSides = 9;
        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides));
        double area = 0.5 * numSides * sideLength * apothem;

        Console.WriteLine("The area of the regular nonagon is: " + area);
    }
}
