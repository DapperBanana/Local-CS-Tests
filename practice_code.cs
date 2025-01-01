
using System;

class NumberConverter
{
    static void Main()
    {
        Console.WriteLine("Number Converter");

        Console.Write("Enter the number to convert: ");
        string numberStr = Console.ReadLine();

        Console.Write("Enter the current base of the number: ");
        int currentBase = int.Parse(Console.ReadLine());

        Console.Write("Enter the target base to convert to: ");
        int targetBase = int.Parse(Console.ReadLine());

        int decimalNumber = ConvertToDecimal(numberStr, currentBase);
        string result = ConvertFromDecimal(decimalNumber, targetBase);

        Console.WriteLine($"The number {numberStr} in base {currentBase} is equal to {result} in base {targetBase}.");
    }

    static int ConvertToDecimal(string number, int baseValue)
    {
        int result = 0;
        for (int i = number.Length - 1, pow = 0; i >= 0; i--, pow++)
        {
            int digit = ConvertDigitToValue(number[i]);
            result += digit * (int)Math.Pow(baseValue, pow);
        }
        return result;
    }

    static string ConvertFromDecimal(int number, int baseValue)
    {
        string result = "";
        while (number > 0)
        {
            int remainder = number % baseValue;
            result = ConvertValueToDigit(remainder) + result;
            number /= baseValue;
        }
        return result;
    }

    static int ConvertDigitToValue(char digit)
    {
        if (char.IsDigit(digit))
        {
            return digit - '0';
        }
        else
        {
            return digit - 'A' + 10;
        }
    }

    static char ConvertValueToDigit(int value)
    {
        if (value < 10)
        {
            return (char)(value + '0');
        }
        else
        {
            return (char)(value - 10 + 'A');
        }
    }
}
