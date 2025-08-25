
using System;

class Program
{
    static void Main()
    {
        double length, width, area;

        // Get input for length
        Console.Write("Enter the length of the rectangle: ");
        length = Convert.ToDouble(Console.ReadLine());
        
        // Get input for width
        Console.Write("Enter the width of the rectangle: ");
        width = Convert.ToDouble(Console.ReadLine());
        
        // Calculate area
        area = length * width;

        // Display the area of the rectangle
        Console.WriteLine($"The area of the rectangle is {area}");
    }
}
