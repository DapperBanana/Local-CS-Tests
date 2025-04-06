
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the base and height of the parallelogram:");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        double height = Convert.ToDouble(Console.ReadLine());

        double area = baseLength * height;

        Console.WriteLine($"The area of the parallelogram is: {area}");
    }
}
