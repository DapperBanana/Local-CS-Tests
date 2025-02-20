
using System;

class Program
{
    static void Main()
    {
        double sideLength;
        double apothem;
        double area;

        // Input side length
        Console.Write("Enter the side length of the regular heptagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        // Calculate apothem
        apothem = sideLength / (2 * Math.Tan(Math.PI / 7));

        // Calculate area
        area = (7 * sideLength * apothem) / 2;

        // Print the area
        Console.WriteLine("The area of the regular heptagon is: " + area);
    }
}
