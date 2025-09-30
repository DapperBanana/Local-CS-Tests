
using System;

class Program
{
    static void Main()
    {
        double sideLength, area;

        Console.WriteLine("Enter the side length of the regular hexadecagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        area = 4 * sideLength * sideLength * Math.Tan(Math.PI / 16);

        Console.WriteLine("The area of the regular hexadecagon is: " + area);
    }
}
