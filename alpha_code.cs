using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius;
        if (double.TryParse(Console.ReadLine(), out radius))
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"The area of the circle is: {area}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value for the radius.");
        }
    }
}