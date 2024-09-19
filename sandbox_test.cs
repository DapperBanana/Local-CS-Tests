
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of sides of the regular polygon:");
        int numSides = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the length of each side of the regular polygon:");
        double sideLength = Convert.ToDouble(Console.ReadLine());
        
        double area = CalculateArea(numSides, sideLength);
        
        Console.WriteLine($"The area of the regular polygon is: {area}");
    }
    
    static double CalculateArea(int numSides, double sideLength)
    {
        double area = (numSides * Math.Pow(sideLength, 2)) / (4 * Math.Tan(Math.PI / numSides));
        return area;
    }
}
