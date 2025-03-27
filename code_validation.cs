
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        double decimalNumber = Convert.ToDouble(Console.ReadLine());

        ConvertToFraction(decimalNumber);
    }

    static void ConvertToFraction(double decimalNumber)
    {
        double tolerance = 0.0001;
        double error = 1.0;
        double numerator = 1;
        double denominator = 1;
        double fraction = 0;

        while (error > tolerance)
        {
            fraction = numerator / denominator;
            if (fraction < decimalNumber)
            {
                numerator++;
            }
            else if (fraction > decimalNumber)
            {
                denominator++;
            }

            error = Math.Abs(decimalNumber - fraction);
        }

        Console.WriteLine($"The fraction equivalent of {decimalNumber} is {numerator}/{denominator}");
    }
}
