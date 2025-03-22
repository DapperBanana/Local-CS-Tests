
using System;

class BaseConverter
{
    public static string ConvertBase(string number, int fromBase, int toBase)
    {
        int decimalNumber = ConvertToDecimal(number, fromBase);
        return ConvertFromDecimal(decimalNumber, toBase);
    }

    private static int ConvertToDecimal(string number, int fromBase)
    {
        int decimalNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int digit = Char.IsDigit(number[i]) ? number[i] - '0' : char.ToUpper(number[i]) - 'A' + 10;
            decimalNumber += digit * (int)Math.Pow(fromBase, number.Length - i - 1);
        }
        return decimalNumber;
    }

    private static string ConvertFromDecimal(int number, int toBase)
    {
        string convertedNumber = "";
        while (number > 0)
        {
            int remainder = number % toBase;
            convertedNumber = (char)(remainder < 10 ? remainder + '0' : remainder - 10 + 'A') + convertedNumber;
            number = number / toBase;
        }
        return convertedNumber;
    }

    static void Main()
    {
        string number = "1010";
        int fromBase = 2;
        int toBase = 10;

        string convertedNumber = ConvertBase(number, fromBase, toBase);

        Console.WriteLine("Converted number: " + convertedNumber);
    }
}
