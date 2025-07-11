
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal decimalNumber = Convert.ToDecimal(Console.ReadLine());

        // Finding the number of digits after the decimal point
        int precision = BitConverter.GetBytes(decimal.GetBits(decimalNumber)[3])[2] - 16;

        // Multiplying the decimal number by the precision to get an integer
        long numerator = (long)(decimalNumber * Math.Pow(10, precision));
        long denominator = (long)Math.Pow(10, precision);

        // Finding the greatest common divisor and simplifying the fraction
        long gcd = GreatestCommonDivisor(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;

        Console.WriteLine($"Fraction: {numerator}/{denominator}");
    }

    static long GreatestCommonDivisor(long a, long b)
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
