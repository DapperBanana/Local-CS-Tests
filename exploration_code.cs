
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        
        double area = Math.PI * radius * radius;
        
        Console.WriteLine($"The area of the circle with radius {radius} is {area}");
    }
}
