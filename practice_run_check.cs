
using System;

class Program
{
    static void Main()
    {
        int n = 11;  // number of sides of hendecagon
        double sideLength = 5;  // length of each side
        
        double area = CalculateHendecagonArea(n, sideLength);
        
        Console.WriteLine($"The area of the hendecagon is: {area}");
    }
    
    static double CalculateHendecagonArea(int n, double sideLength)
    {
        double apothem = sideLength / (2 * Math.Tan(Math.PI / n));
        double perimeter = n * sideLength;
        
        double area = 0.5 * apothem * perimeter;
        
        return area;
    }
}
