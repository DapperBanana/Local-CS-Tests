
using System;

class Program
{
    static void Main()
    {
        int numOfSides = 16; // Number of sides in the regular hexadecagon
        double sideLength = 5.0; // Length of each side of the regular hexadecagon
        
        double apothem = sideLength / (2 * Math.Tan(Math.PI / numOfSides)); // Calculate the apothem of the hexadecagon
        double area = 0.5 * numOfSides * sideLength * apothem; // Calculate the area of the hexadecagon
        
        Console.WriteLine($"The area of the regular hexadecagon is: {area}");
    }
}
