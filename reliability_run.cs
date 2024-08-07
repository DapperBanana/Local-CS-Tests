
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number to convert:");
        string number = Console.ReadLine();

        Console.WriteLine("Enter current base:");
        int currentBase = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter new base:");
        int newBase = int.Parse(Console.ReadLine());

        Console.WriteLine($"Converted number: {ConvertNumber(number, currentBase, newBase)}");
    }

    static string ConvertNumber(string number, int currentBase, int newBase)
    {
        int decimalNumber = ConvertToDecimal(number, currentBase);
        return ConvertFromDecimal(decimalNumber, newBase);
    }

    static int ConvertToDecimal(string number, int baseValue)
    {
        int result = 0;
        int power = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            int digit = GetDigitValue(number[i]);
            result += digit * (int)Math.Pow(baseValue, power);
            power++;
        }

        return result;
    }

    static string ConvertFromDecimal(int decimalNumber, int newBase)
    {
        string result = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % newBase;
            result = GetDigit(remainder) + result;
            decimalNumber /= newBase;
        }

        return result;
    }

    static int GetDigitValue(char digit)
    {
        if (Char.IsDigit(digit))
        {
            return int.Parse(digit.ToString());
        }
        else
        {
            return digit - 'A' + 10;
        }
    }

    static char GetDigit(int value)
    {
        if (value < 10)
        {
            return value.ToString()[0];
        }
        else
        {
            return (char)('A' + (value - 10));
        }
    }
}
