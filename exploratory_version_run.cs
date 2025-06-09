
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal decimalNumber = Convert.ToDecimal(Console.ReadLine());

        ConvertDecimalToFraction(decimalNumber);
    }

    static void ConvertDecimalToFraction(decimal decimalNumber)
    {
        decimal epsilon = 0.0001m;
        decimal error = Math.Abs(decimalNumber - Math.Round(decimalNumber));

        for (int i = 1; error > epsilon; i++)
        {
            decimal denominator = (decimal)(1 / Math.Pow(10, i));
            decimal fraction = Math.Round(decimalNumber * denominator);
            error = Math.Abs(decimalNumber - fraction / denominator);
            
            Console.WriteLine("{0} = {1}/{2}", decimalNumber, fraction, denominator);
        }
    }
}
