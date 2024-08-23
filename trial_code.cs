
using System;

class Program
{
    static void Main()
    {
        int n = 11; // Number of sides of the hendecagon
        double side_length = 5; // Length of each side of the hendecagon

        double area = CalculateAreaOfHendecagon(n, side_length);
        
        Console.WriteLine("The area of the regular hendecagon is: " + area);
    }

    static double CalculateAreaOfHendecagon(int n, double side_length)
    {
        double apothem = side_length / (2 * Math.Tan(Math.PI / n));
        double perimeter = n * side_length;
        double area = 0.5 * perimeter * apothem;
        
        return area;
    }
}
