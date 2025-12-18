using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        if(double.TryParse(Console.ReadLine(), out double decimalNumber))
        {
            string fraction = DecimalToFraction(decimalNumber);
            Console.WriteLine($"Fraction: {fraction}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static string DecimalToFraction(double decimalNumber, double tolerance = 1.0E-6)
    {
        if (decimalNumber == 0)
            return "0";

        bool isNegative = decimalNumber < 0;
        decimalNumber = Math.Abs(decimalNumber);

        // Separate the integer part from the fractional part
        long wholePart = (long)Math.Floor(decimalNumber);
        double fractionalPart = decimalNumber - wholePart;

        if (fractionalPart < tolerance)
        {
            return (isNegative ? "-" : "") + wholePart.ToString();
        }

        // Use continued fractions or Farey sequence to approximate the fractional part
        const int maxDenominator = 1000000;
        long numerator = 0;
        long denominator = 1;
        double bestError = double.MaxValue;

        for (long denom = 1; denom <= maxDenominator; denom++)
        {
            long num = (long)Math.Round(fractionalPart * denom);
            double approx = (double)num / denom;
            double error = Math.Abs(fractionalPart - approx);
            if (error < bestError)
            {
                bestError = error;
                numerator = num;
                denominator = denom;
                if (error < tolerance)
                {
                    break;
                }
            }
        }

        // Combine integer and fractional parts
        long combinedNumerator = wholePart * denominator + numerator;

        // Simplify the fraction
        long gcd = GCD(combinedNumerator, denominator);
        combinedNumerator /= gcd;
        denominator /= gcd;

        if (wholePart == 0)
        {
            return (isNegative ? "-" : "") + $"{combinedNumerator}/{denominator}";
        }
        else
        {
            long remNumerator = combinedNumerator % denominator;
            long intPart = combinedNumerator / denominator;
            if (remNumerator == 0)
            {
                return (isNegative ? "-" : "") + $"{intPart}";
            }
            else
            {
                return (isNegative ? "-" : "") + $"{intPart} {Math.Abs(remNumerator)}/{denominator}";
            }
        }
    }

    static long GCD(long a, long b)
    {
        while (b != 0)
        {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}