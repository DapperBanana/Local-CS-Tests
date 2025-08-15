
using System;

class Program
{
    static void Main()
    {
        int n = 11; // Number of sides of the hendecagon
        double sideLength = 5; // Length of each side of the hendecagon

        double area = CalculateHendecagonArea(n, sideLength);
        
        Console.WriteLine($"The area of the regular hendecagon is: {area}");
    }

    static double CalculateHendecagonArea(int n, double sideLength)
    {
        return (n * sideLength * sideLength) / (4 * Math.Tan(Math.PI / n));
    }
}
