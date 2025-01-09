

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal number = Convert.ToDecimal(Console.ReadLine());

        Fraction fraction = ConvertDecimalToFraction(number);

        Console.WriteLine("Fraction representation: {0}/{1}", fraction.Numerator, fraction.Denominator);
    }

    static Fraction ConvertDecimalToFraction(decimal number)
    {
        decimal denominator = 1;
        while (number % 1 != 0)
        {
            number *= 10;
            denominator *= 10;
        }

        decimal numerator = (int)number;

        decimal gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;

        return new Fraction((int)numerator, (int)denominator);
    }

    static decimal GCD(decimal a, decimal b)
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

class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }
}
