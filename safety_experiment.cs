
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        
        Console.WriteLine("Enter the side length of the regular icosahedron: ");
        sideLength = Convert.ToDouble(Console.ReadLine());
        
        double area = CalculateIcosahedronArea(sideLength);
        
        Console.WriteLine("The area of the regular icosahedron is: " + area);
    }
    
    static double CalculateIcosahedronArea(double sideLength)
    {
        double a = sideLength * Math.Sqrt(3);
        double area = 5 * Math.Sqrt(3) * Math.Pow(a, 2);
        
        return area;
    }
}
