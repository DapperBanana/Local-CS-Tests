
using System;

class Program
{
    static void Main()
    {
        // Input the side length of the hendecagon
        Console.Write("Enter the side length of the hendecagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the hendecagon
        double area = (11 * sideLength * sideLength) / (4 * Math.Tan(Math.PI / 11));

        // Display the result
        Console.WriteLine($"The area of the hendecagon is: {area}");
    }
}
