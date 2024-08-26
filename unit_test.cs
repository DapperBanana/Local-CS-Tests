
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        double decimalNumber = Convert.ToDouble(Console.ReadLine());

        int wholeNumberPart = (int)decimalNumber;
        double decimalPart = decimalNumber - wholeNumberPart;

        int precision = 1000000;
        int numerator = (int)(decimalPart * precision);
        int denominator = precision;

        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;

        if (wholeNumberPart != 0)
        {
            Console.WriteLine($"{wholeNumberPart} {numerator}/{denominator}");
        }
        else
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}
