
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;
        Console.WriteLine($"The area of the rectangle is: {area}");
    }
}
