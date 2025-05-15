
using System;

class Program
{
    static void Main()
    {
        double radius;
        
        // Get the radius input from the user
        Console.Write("Enter the radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());
        
        // Calculate the area of the circle
        double area = Math.PI * radius * radius;
        
        // Display the result
        Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
    }
}
