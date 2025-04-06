
using System;

class Program
{
    static void Main()
    {
        // Get input temperature in Celsius
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        // Convert Celsius to Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Display the result
        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
    }
}
