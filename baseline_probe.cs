
using System;

class Program
{
    static void Main()
    {
        double sideLength, apothem, area;
        int n;

        Console.Write("Enter the side length of the nonagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the number of sides in the nonagon: ");
        n = Convert.ToInt32(Console.ReadLine());

        apothem = sideLength / (2 * Math.Tan(Math.PI / n));
        area = (n * sideLength * apothem) / 2;

        Console.WriteLine("The area of the regular nonagon is: " + area);
    }
}
