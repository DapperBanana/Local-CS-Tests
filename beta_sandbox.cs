
using System;

class Program
{
    static void Main()
    {
        double topLength, bottomLength, height;
        
        // Input top length, bottom length, and height of the trapezoid
        Console.Write("Enter the top length of the trapezoid: ");
        topLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the bottom length of the trapezoid: ");
        bottomLength = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the height of the trapezoid: ");
        height = Convert.ToDouble(Console.ReadLine());

        // Calculate area of the trapezoid
        double area = 0.5 * (topLength + bottomLength) * height;

        // Output the area of the trapezoid
        Console.WriteLine($"The area of the trapezoid is: {area}");
    }
}
