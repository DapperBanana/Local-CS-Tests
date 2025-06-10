
using System;

class Program
{
    static void Main()
    {
        int numberOfSides = 16;
        double sideLength = 10; // You can change the side length as needed

        double area = (numberOfSides * Math.Pow(sideLength, 2)) / (4 * Math.Tan(Math.PI / numberOfSides));

        Console.WriteLine("The area of the regular hexadecagon is: " + area);
    }
}
