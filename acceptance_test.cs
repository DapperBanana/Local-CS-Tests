
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal decimalNumber = Convert.ToDecimal(Console.ReadLine());

        decimal epsilon = 0.0001M;
        decimal error = decimal.MaxValue;
        long numerator = 0;
        long denominator = 1;

        for (long i = 1; i < 10000; i++)
        {
            decimal fraction = Math.Round(decimalNumber * i) / i;
            if (Math.Abs(decimalNumber - fraction) < error)
            {
                error = Math.Abs(decimalNumber - fraction);
                numerator = (long)Math.Round(decimalNumber * i);
                denominator = i;
            }
            if (error < epsilon)
            {
                break;
            }
        }

        Console.WriteLine($"Fraction representation: {numerator}/{denominator}");
    }
}
