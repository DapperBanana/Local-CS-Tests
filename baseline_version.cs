
using System;

class DecimalToFraction
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number: ");
        double decimalNumber = double.Parse(Console.ReadLine());

        ConvertToFraction(decimalNumber);
    }

    static void ConvertToFraction(double decimalNumber)
    {
        double numerator = decimalNumber;
        double denominator = 1.0;

        while (numerator % 1 != 0)
        {
            numerator *= 10;
            denominator *= 10;
        }

        double gcd = GCD((int)numerator, (int)denominator);

        int finalNumerator = (int)numerator / (int)gcd;
        int finalDenominator = (int)denominator / (int)gcd;

        Console.WriteLine($"The fraction of {decimalNumber} is {finalNumerator}/{finalDenominator}");
    }

    static int GCD(int a, int  b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
}
