
using System;

class Program
{
    static void Main()
    {
        // Get the number of sides and length of each side of the polygon from the user
        Console.WriteLine("Enter the number of sides of the polygon:");
        int sides = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the length of each side of the polygon:");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the regular polygon
        double area = (sides * Math.Pow(sideLength, 2)) / (4 * Math.Tan(Math.PI / sides));

        // Display the result
        Console.WriteLine($"The area of the regular polygon is: {area}");
    }
}
