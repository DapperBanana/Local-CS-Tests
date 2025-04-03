
using System;

class Program
{
    static void Main()
    {
        int sideLength = 5; // Replace this with the side length of the hexadecagon
        int numSides = 16; // Number of sides in a hexadecagon

        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides));
        double area = (numSides * sideLength * apothem) / 2;

        Console.WriteLine("The area of the regular hexadecagon is: " + area);
    }
}
