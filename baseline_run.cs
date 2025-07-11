
using System;

class Program
{
    static void Main()
    {
        int numSides = 11;
        double sideLength = 5;
        
        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides));
        double area = (numSides * sideLength * apothem) / 2;
        
        Console.WriteLine("Area of the hendecagon is: " + area);
    }
}
