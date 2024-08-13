
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal decimalNumber = Convert.ToDecimal(Console.ReadLine());
        
        Fraction fraction = ConvertToFraction(decimalNumber);
        
        Console.WriteLine($"Equivalent fraction: {fraction.Numerator}/{fraction.Denominator}");
    }
    
    static Fraction ConvertToFraction(decimal number)
    {
        decimal tolerance = 0.0001m;
        decimal h1 = 1;
        decimal h2;
        decimal k1 = 0;
        decimal k2;
        decimal y = number;
        decimal error = decimal.MaxValue;

        do
        {
            y = 1 / (y - Math.Truncate(y));
            h2 = h1 * Math.Truncate(y) + k1;
            k2 = k1 + h1 * Math.Truncate(y);

            if (Math.Abs(y - Math.Truncate(y)) < tolerance)
            {
                break;
            }

            h1 = h2;
            k1 = k2;
        } while (Math.Abs(number - h2 / k2) > tolerance);

        return new Fraction((int)h2, (int)k2);
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
