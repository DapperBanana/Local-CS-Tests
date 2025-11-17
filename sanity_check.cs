
using System;

class DecimalToFractionConverter
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number: ");
        decimal decimalNumber = Convert.ToDecimal(Console.ReadLine());

        Fraction fraction = ConvertToFraction(decimalNumber);
        Console.WriteLine($"Fraction representation of {decimalNumber}: {fraction.Numerator}/{fraction.Denominator}");
    }

    static Fraction ConvertToFraction(decimal decimalNumber)
    {
        decimal numerator = decimal.Truncate(decimalNumber * 100000000);
        decimal denominator = 100000000;

        long gcd = CalculateGCD(Convert.ToInt64(numerator), Convert.ToInt64(denominator));
        numerator /= gcd;
        denominator /= gcd;

        return new Fraction(Convert.ToInt64(numerator), Convert.ToInt64(denominator));
    }

    static long CalculateGCD(long a, long b)
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

class Fraction
{
    public long Numerator { get; }
    public long Denominator { get; }

    public Fraction(long numerator, long denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }
}
