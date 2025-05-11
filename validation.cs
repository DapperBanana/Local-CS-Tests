
using System;

class Program
{
    static void Main()
    {
        int sideLength = 5; // Change this to the desired side length of the dodecagon

        double apothem = sideLength * Math.Sqrt(3); // Calculate the apothem of the dodecagon
        double area = 6 * sideLength * apothem; // Calculate the area of the dodecagon

        Console.WriteLine("The area of the regular dodecagon with side length " + sideLength + " is: " + area);
    }
}
