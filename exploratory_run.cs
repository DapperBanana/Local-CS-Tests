
using System;

class Program
{
    static void Main()
    {
        double celsius, fahrenheit;

        Console.WriteLine("Enter the temperature in Celsius: ");
        celsius = Convert.ToDouble(Console.ReadLine());

        fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit);
    }
}
