
using System;

class Program
{
    static void Main()
    {
        int sideLength;
        
        Console.WriteLine("Enter the length of a side of the regular nonagon: ");
        sideLength = Convert.ToInt32(Console.ReadLine());
        
        double area = CalculateNonagonArea(sideLength);
        
        Console.WriteLine("The area of the regular nonagon is: " + area);
    }
    
    static double CalculateNonagonArea(int sideLength)
    {
        int numSides = 9;
        double apothem = sideLength / (2.0 * Math.Tan(Math.PI / numSides));
        double perimeter = numSides * sideLength;
        
        return 0.5 * apothem * perimeter;
    }
}
