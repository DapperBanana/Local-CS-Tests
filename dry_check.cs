
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        
        Console.Write("Enter the side length of the regular nonagon: ");
        sideLength = double.Parse(Console.ReadLine());
        
        double area = CalculateAreaOfNonagon(sideLength);
        
        Console.WriteLine("The area of the regular nonagon is: " + area);
    }
    
    static double CalculateAreaOfNonagon(double sideLength)
    {
        const int numSides = 9;
        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides));
        double perimeter = sideLength * numSides;
        
        return 0.5 * apothem * perimeter;
    }
}
