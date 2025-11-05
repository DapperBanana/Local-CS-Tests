
using System;

class Program
{
    static void Main()
    {
        // Get the side length of the decagon from the user
        Console.Write("Enter the side length of the regular decagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        // Calculate the apothem of the decagon
        double apothem = sideLength / (2 * Math.Tan(Math.PI / 10));

        // Calculate the area of the regular decagon
        double area = (5 * sideLength * apothem);

        Console.WriteLine($"The area of the regular decagon is: {area}");
    }
}
