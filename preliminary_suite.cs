
using System;

class Program
{
    static void Main()
    {
        // Get the length of a side of the hendecagon from the user
        Console.WriteLine("Enter the length of a side of the hendecagon:");
        double sideLength = double.Parse(Console.ReadLine());

        // Calculate the area of the hendecagon
        double area = (11 * Math.Pow(sideLength, 2)) / (4 * Math.Tan(Math.PI / 11));

        // Display the area of the hendecagon
        Console.WriteLine("The area of the hendecagon is: " + area);
    }
}
