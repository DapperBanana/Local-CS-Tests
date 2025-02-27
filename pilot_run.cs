
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number:");
        decimal number = decimal.Parse(Console.ReadLine());

        string result = DecimalToFraction(number);
        Console.WriteLine($"The fraction equivalent of {number} is {result}");
    }

    static string DecimalToFraction(decimal number)
    {
        decimal tolerance = 1.0E-6M;
        decimal[] fraction = { 0, 1 };
        decimal z = number;

        decimal n = (decimal)Math.Floor(z);
        z -= n;

        while (z > tolerance && fraction[1] < 1000000)
        {
            z = 1M / z;
            int a = (int)Math.Floor(z);
            fraction = new[] { a * fraction[0] + fraction[1], fraction[0] };
            z -= a;
        }

        return $"{fraction[0]}/{fraction[1]}";
    }
}
