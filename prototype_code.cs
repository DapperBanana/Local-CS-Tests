
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of one side of the regular hexagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double area = CalculateHexagonArea(sideLength);
        
        Console.WriteLine("The area of the hexagon is: " + area);
    }

    static double CalculateHexagonArea(double sideLength)
    {
        return (6 * sideLength * sideLength) / (4 * Math.Tan(Math.PI / 6));
    }
}
