
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal decimalNumber = Convert.ToDecimal(Console.ReadLine());

        int precision = 6; // maximum number of decimal places to consider

        decimal factor = 1;
        for (int i = 0; i < precision; i++)
        {
            factor *= 10;
        }

        decimal numerator = decimalNumber * factor;
        decimal denominator = factor;

        // find the greatest common divisor
        decimal gcd = GCD(numerator, denominator);

        // simplify the fraction
        decimal simplifiedNumerator = numerator / gcd;
        decimal simplifiedDenominator = denominator / gcd;

        Console.WriteLine("Equivalent fraction: " + simplifiedNumerator + "/" + simplifiedDenominator);
    }

    static decimal GCD(decimal a, decimal b)
    {
        while (b != 0)
        {
            decimal temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
