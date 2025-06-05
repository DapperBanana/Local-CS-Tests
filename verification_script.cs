
using System;

class Program
{
    static void Main()
    {
        int numSides;
        double sideLength;
        double apothem;

        Console.WriteLine("Enter the number of sides of the regular polygon:");
        numSides = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the length of each side of the regular polygon:");
        sideLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the apothem of the regular polygon:");
        apothem = Convert.ToDouble(Console.ReadLine());

        double perimeter = numSides * sideLength;
        double area = 0.5 * perimeter * apothem;

        Console.WriteLine($"The area of the regular polygon is: {area}");
    }
}
