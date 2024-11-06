
using System;

class Program
{
    static void Main()
    {
        // Prompt user to enter the side length of the regular hendecagon
        Console.WriteLine("Enter the side length of the regular hendecagon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        // Calculate the apothem of the hendecagon
        double apothem = sideLength / (2 * Math.Tan(Math.PI / 11));

        // Calculate the area of the hendecagon
        double area = (11 * sideLength * apothem) / 2;

        // Display the area of the hendecagon
        Console.WriteLine($"The area of the regular hendecagon is: {area}");
    }
}
