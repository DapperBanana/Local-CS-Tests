
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());

        decimal wholeNumber = Math.Truncate(number);
        decimal decimalPart = number - wholeNumber;

        int precision = 6; // Number of decimal places
        decimal denominator = (decimal)(Math.Pow(10, precision));
        decimal numerator = decimalPart * denominator;

        // Find the greatest common divisor (GCD) to simplify the fraction
        decimal gcd = GCD(Convert.ToInt32(numerator), Convert.ToInt32(denominator));
        numerator /= gcd;
        denominator /= gcd;

        // Calculate the final fraction
        int wholeNumberInt = Convert.ToInt32(wholeNumber);
        if (wholeNumberInt != 0)
        {
            Console.WriteLine($"Fraction: {(wholeNumberInt * denominator + numerator)}/{denominator}");
        }
        else
        {
            Console.WriteLine($"Fraction: {numerator}/{denominator}");
        }
    }

    // Method to find the Greatest Common Divisor (GCD) using Euclidean algorithm
    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        return GCD(b, a % b);
    }
}
