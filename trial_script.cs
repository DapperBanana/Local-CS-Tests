
using System;

class Program
{
    static void Main()
    {
        double baseLength, height;
        
        // Input base length and height of the parallelogram
        Console.WriteLine("Enter the base length of the parallelogram: ");
        baseLength = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the height of the parallelogram: ");
        height = Convert.ToDouble(Console.ReadLine());
        
        // Calculate the area of the parallelogram
        double area = baseLength * height;
        
        // Display the area of the parallelogram
        Console.WriteLine("The area of the parallelogram is: " + area);
    }
}
