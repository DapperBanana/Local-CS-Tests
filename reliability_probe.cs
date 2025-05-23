
using System;

class Program
{
    static void Main()
    {
        double decimalNumber = 3.14;

        // Convert the decimal number to a fraction
        double epsilon = 0.0001;
        double denominator = 1.0;
        while (Math.Abs(decimalNumber * denominator - Math.Round(decimalNumber * denominator)) > epsilon)
        {
            denominator++;
        }

        long numerator = (long)Math.Round(decimalNumber * denominator);

        // Reduce the fraction to its simplest form
        long gcd = GCD(numerator, (long)denominator);
        numerator /= gcd;
        denominator /= gcd;

        Console.WriteLine($"{decimalNumber} as a fraction is: {numerator}/{denominator}");
    }

    static long GCD(long a, long b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return GCD(b, a % b);
        }
    }
}
