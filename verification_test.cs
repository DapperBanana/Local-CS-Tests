
using System;

class Program
{
    static void Main()
    {
        int numSides = 16; // number of sides in a regular hexadecagon
        double sideLength = 5; // length of each side of the hexadecagon

        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides)); // apothem formula
        double area = (numSides * sideLength * apothem) / 2; // area formula

        Console.WriteLine("The area of the regular hexadecagon is: " + area);
    }
}
