
using System;

class DecimalToFractionConverter
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal decimalNumber = decimal.Parse(Console.ReadLine());

        decimal tolerance = 0.0001m;
        decimal numerator = 1;
        decimal denominator = 1;
        decimal fraction = numerator / denominator;

        while (Math.Abs(fraction - decimalNumber) > tolerance)
        {
            if (fraction < decimalNumber)
            {
                numerator++;
            }
            else
            {
                denominator++;
                numerator = (decimal)(decimalNumber * denominator);
            }
            fraction = numerator / denominator;
        }

        Console.WriteLine($"The fraction equivalent of {decimalNumber} is {numerator}/{denominator}");
    }
}
