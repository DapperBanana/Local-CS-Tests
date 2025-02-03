
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal decimalNumber = decimal.Parse(Console.ReadLine());

        // Calculate the fraction
        decimal tolerance = 0.0001M;
        decimal n = decimal.Truncate(decimalNumber);
        decimal fraction = 0;
        decimal remainder = decimalNumber - n;
        decimal error = Math.Abs(remainder - fraction);

        while (error > tolerance)
        {
            decimal reciprocal = 1 / remainder;
            decimal m = decimal.Truncate(reciprocal);
            fraction += m;
            remainder = reciprocal - m;
            error = Math.Abs(remainder - fraction);
        }

        decimal numerator = n * fraction + 1;
        decimal denominator = fraction;

        Console.WriteLine($"The fraction is: {numerator}/{denominator}");
    }
}
