
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        double decimalNumber = double.Parse(Console.ReadLine());

        Fraction fraction = ConvertDecimalToFraction(decimalNumber);

        Console.WriteLine($"Fraction: {fraction.Numerator}/{fraction.Denominator}");
    }

    static Fraction ConvertDecimalToFraction(double decimalNumber)
    {
        // Set a maximum number of iterations to prevent infinite loop
        int maxIterations = 100;
        int i = 0;

        // Initialize variables for fraction
        double tolerance = 0.0001;
        double error = 1.0;
        double previousDenominator = 0;
        double numerator = decimalNumber;
        double denominator = 1.0;

        while (error > tolerance && i < maxIterations)
        {
            i++;
            double flooredNumber = Math.Floor(numerator);

            double temp = denominator;
            denominator = flooredNumber * denominator + previousDenominator;
            previousDenominator = temp;

            if (Math.Abs(numerator - flooredNumber) < double.Epsilon)
            {
                break;
            }

            numerator = 1.0 / (numerator - flooredNumber);

            error = Math.Abs(decimalNumber - (double)numerator / (double)denominator);
        }

        return new Fraction((int)numerator, (int)denominator);
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
