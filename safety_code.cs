
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of a side of the regular nonagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double apothem = sideLength / (2 * Math.Tan(Math.PI / 9));
        double area = (9 * sideLength * apothem) / 2;

        Console.WriteLine($"The area of the regular nonagon is: {area}");
    }
}
