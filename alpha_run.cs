
using System;

class Program
{
    static void Main(string[] args)
    {
        double decimalNumber;

        Console.Write("Enter a decimal number: ");
        decimalNumber = Convert.ToDouble(Console.ReadLine());

        ConvertToFraction(decimalNumber);
    }

    static void ConvertToFraction(double decimalNumber)
    {
        double tolerance = 0.0001;
        double error = double.MaxValue;
        int numerator = 1;
        int denominator = 1;

        for (int i = 1; error > tolerance; i++)
        {
            double fraction = Math.Round(decimalNumber * i);
            double newError = Math.Abs(decimalNumber - (fraction / i));

            if (newError < error)
            {
                error = newError;
                numerator = (int)fraction;
                denominator = i;
            }
        }

        Console.WriteLine($"The decimal number {decimalNumber} as a fraction is: {numerator}/{denominator}");
    }
}
