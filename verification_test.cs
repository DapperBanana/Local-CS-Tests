
using System;

class Program
{
    static void Main()
    {
        double decimalNumber = 3.14;

        Console.WriteLine($"Decimal number: {decimalNumber}");
        Console.WriteLine($"Fraction: {ConvertToFraction(decimalNumber)}");
    }

    static string ConvertToFraction(double decimalNumber)
    {
        double tolerance = 0.0001;
        double error = double.MaxValue;
        double numerator = 0;
        double denominator = 1;
        double fraction = 0;

        while (Math.Abs(fraction - decimalNumber) > tolerance)
        {
            if (fraction < decimalNumber)
            {
                numerator++;
            }
            else
            {
                denominator++;
            }

            fraction = numerator / denominator;
            error = Math.Abs(fraction - decimalNumber);
        }

        return $"{numerator}/{denominator}";
    }
}
