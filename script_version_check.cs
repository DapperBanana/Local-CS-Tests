
using System;

class BaseConverter
{
    public static int ConvertBaseToDecimal(string number, int baseFrom)
    {
        int result = 0;
        int power = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            int digitValue = GetDigitValue(number[i]);

            result += digitValue * (int)Math.Pow(baseFrom, power);
            power++;
        }

        return result;
    }

    public static string ConvertDecimalToBase(int decimalNumber, int baseTo)
    {
        string result = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % baseTo;
            result = GetCharValue(remainder) + result;
            decimalNumber = decimalNumber / baseTo;
        }

        return result;
    }

    private static int GetDigitValue(char digit)
    {
        return char.IsDigit(digit) ? digit - '0' : char.ToUpper(digit) - 'A' + 10;
    }

    private static char GetCharValue(int value)
    {
        return value < 10 ? (char)(value + '0') : (char)(value - 10 + 'A');
    }

    static void Main()
    {
        string number = "1010";
        int baseFrom = 2;
        int decimalNumber = ConvertBaseToDecimal(number, baseFrom);

        Console.WriteLine($"Decimal representation of {number} in base {baseFrom}: {decimalNumber}");

        int baseTo = 16;
        string convertedNumber = ConvertDecimalToBase(decimalNumber, baseTo);

        Console.WriteLine($"Number {decimalNumber} in base 10 converted to base {baseTo}: {convertedNumber}");
    }
}
