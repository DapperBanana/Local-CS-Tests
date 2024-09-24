
using System;

class Program
{
    static void Main()
    {
        double sideLength, height;
        
        // Input the side length and height of the pentagonal prism
        Console.Write("Enter the side length of the pentagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the height of the pentagonal prism: ");
        height = Convert.ToDouble(Console.ReadLine());
        
        // Calculate the area of the pentagonal prism
        double area = 5 * sideLength * sideLength + 5 * sideLength * height;
        
        Console.WriteLine($"The area of the pentagonal prism is: {area}");
    }
}
