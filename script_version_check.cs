
using System;

class Program
{
    static void Main()
    {
        double lengthSide, numSides;
        
        Console.WriteLine("Enter the length of a side of the polygon:");
        lengthSide = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the number of sides of the polygon:");
        numSides = Convert.ToDouble(Console.ReadLine());
        
        double area = (numSides * lengthSide * lengthSide) / (4.0 * Math.Tan(Math.PI / numSides));
        
        Console.WriteLine("The area of the regular polygon is: " + area);
    }
}
