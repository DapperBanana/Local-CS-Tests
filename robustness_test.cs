
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        double apothem;

        Console.WriteLine("Enter the side length of the decagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the apothem of the decagon: ");
        apothem = Convert.ToDouble(Console.ReadLine());

        double area = (5.0 / 2.0) * sideLength * apothem;

        Console.WriteLine("The area of the regular decagon is: {0}", area);
    }
}
