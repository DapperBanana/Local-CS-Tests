
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        double decimalNumber = double.Parse(Console.ReadLine());

        double fraction = decimalNumber - Math.Truncate(decimalNumber);
        double denominator = Math.Pow(10, fraction.ToString().Length);

        double numerator = decimalNumber * denominator;

        double gcd = FindGcd((int)numerator, (int)denominator);
        int finalNumerator = (int)(numerator / gcd);
        int finalDenominator = (int)(denominator / gcd);

        Console.WriteLine($"Fraction: {finalNumerator}/{finalDenominator}");
    }

    private static int FindGcd(int a, int b)
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
