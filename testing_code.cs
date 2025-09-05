
using System;

class Program
{
    static void Main()
    {
        double sideLength, apothem;

        Console.Write("Enter the side length of the heptagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the apothem of the heptagon: ");
        apothem = Convert.ToDouble(Console.ReadLine());

        double area = (7 * sideLength * apothem) / 2;

        Console.WriteLine("The area of the regular heptagon is: " + area);
    }
}
