
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        double apothem;
        double area;

        Console.Write("Enter the side length of the nonagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        // Calculate the apothem of the nonagon
        apothem = sideLength / (2 * Math.Tan(Math.PI / 9));

        // Calculate the area of the nonagon
        area = 9 * sideLength * apothem / 2;

        Console.WriteLine($"The area of the regular nonagon is: {area}");
    }
}
