
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the hendecagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double area = CalculateHendecagonArea(sideLength);

        Console.WriteLine($"The area of the hendecagon is: {area}");
    }

    static double CalculateHendecagonArea(double sideLength)
    {
        double apothemLength = sideLength / (2 * Math.Tan(Math.PI / 11));
        double perimeter = sideLength * 11;
        
        double area = 0.5 * apothemLength * perimeter;

        return area;
    }
}
