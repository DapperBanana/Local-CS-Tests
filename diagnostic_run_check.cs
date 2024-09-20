
using System;

class Program
{
    static void Main()
    {
        double sideLength, area;
        Console.WriteLine("Enter the side length of the octagon:");
        sideLength = Convert.ToDouble(Console.ReadLine());

        area = 2 * (1 + Math.Sqrt(2)) * Math.Pow(sideLength, 2);
        
        Console.WriteLine("The area of the regular octagon is: " + area);
    }
}
