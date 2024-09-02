
using System;

class Program
{
    static void Main()
    {
        int numSides = 16; // Number of sides of the hexadecagon
        double sideLength = 5; // Length of each side

        // Calculate the area of the hexadecagon
        double area = (numSides * Math.Pow(sideLength, 2)) / (4 * Math.Tan(Math.PI / numSides));

        Console.WriteLine("Area of the regular hexadecagon: " + area);
    }
}
