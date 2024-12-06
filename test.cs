
using System;

class Program
{
    static void Main()
    {
        // Input the side length of the hexadecagon
        Console.Write("Enter the side length of the hexadecagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the regular hexadecagon
        double perimeter = 16 * sideLength;
        double apothem = sideLength * Math.Sqrt(3);
        double area = (perimeter * apothem) / 2;

        Console.WriteLine("The area of the regular hexadecagon is: " + area);
    }
}
