
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal decimalNumber = decimal.Parse(Console.ReadLine());

        Fraction fraction = ConvertToFraction(decimalNumber);

        Console.WriteLine($"Fraction representation: {fraction.Numerator}/{fraction.Denominator}");
    }

    static Fraction ConvertToFraction(decimal decimalNumber)
    {
        decimal tolerance = 0.0001M;

        decimal numerator = decimal.Round(decimalNumber);
        decimal denominator = 1;

        while (Math.Abs(decimalNumber - numerator/denominator) > tolerance)
        {
            denominator++;
            numerator = decimal.Round(decimalNumber * denominator);
        }

        return new Fraction((int)numerator, (int)denominator);
    }
}

class Fraction
{
    public int Numerator { get; }
    public int Denominator { get; }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }
}
