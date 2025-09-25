
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal decimalNumber = decimal.Parse(Console.ReadLine());
        
        decimal numerator = decimalNumber * 1000000;
        decimal denominator = 1000000;
        
        decimal gcd = GCD((long)numerator, (long)denominator);
        
        long simplifiedNumerator = (long)(numerator / gcd);
        long simplifiedDenominator = (long)(denominator / gcd);

        Console.WriteLine($"Fraction: {simplifiedNumerator}/{simplifiedDenominator}");
    }

    static long GCD(long a, long b)
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
