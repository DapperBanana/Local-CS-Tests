
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the hendecagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double apothemLength = sideLength / (2 * Math.Tan(Math.PI / 11));
        double area = (11 * apothemLength * sideLength) / 2;

        Console.WriteLine($"The area of the hendecagon is: {area}");
    }
}
