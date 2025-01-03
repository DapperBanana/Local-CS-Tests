
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the regular decagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double apothem = sideLength / (2 * Math.Tan(Math.PI / 10)); // Calculate the apothem
        double area = (5 * sideLength * apothem); // Calculate the area

        Console.WriteLine("The area of the regular decagon is: " + area);
    }
}
