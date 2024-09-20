
using System;

class Program
{
    static void Main()
    {
        int sideLength;
        double apothem;
        double area;

        // Get the length of the side of the hendecagon from user
        Console.Write("Enter the length of the side of the hendecagon: ");
        sideLength = Convert.ToInt32(Console.ReadLine());

        // Calculate the apothem of the hendecagon
        apothem = sideLength / (2 * Math.Tan(Math.PI / 11));

        // Calculate the area of the hendecagon
        area = (11 * sideLength * apothem) / 2;

        Console.WriteLine("The area of the regular hendecagon is: {0}", area);
    }
}
