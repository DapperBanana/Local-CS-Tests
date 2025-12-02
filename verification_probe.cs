using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the length of a side of the decagon
        Console.Write("Enter the length of a side of the decagon: ");
        double sideLength;
        if (!double.TryParse(Console.ReadLine(), out sideLength) || sideLength <= 0)
        {
            Console.WriteLine("Please enter a valid positive number for the side length.");
            return;
        }

        // Number of sides in a decagon
        int n = 10;

        // Calculate the apothem (a) of the decagon
        double apothem = sideLength / (2 * Math.Tan(Math.PI / n));

        // Calculate the area of the decagon
        double area = (n * sideLength * apothem) / 2;

        // Output the result
        Console.WriteLine($"The area of the decagon is: {area:F2}");
    }
}