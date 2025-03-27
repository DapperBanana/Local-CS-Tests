
using System;

class BaseConverter
{
    static void Main()
    {
        Console.Write("Enter the number to convert: ");
        string num = Console.ReadLine();

        Console.Write("Enter the base of the number: ");
        int fromBase = int.Parse(Console.ReadLine());

        Console.Write("Enter the target base: ");
        int toBase = int.Parse(Console.ReadLine());

        int decimalNum = ConvertToDecimal(num, fromBase);
        string result = ConvertFromDecimal(decimalNum, toBase);

        Console.WriteLine($"The converted number is: {result}");
    }

    static int ConvertToDecimal(string num, int fromBase)
    {
        int result = 0;

        for (int i = 0; i < num.Length; i++)
        {
            result = result * fromBase + (int)Char.GetNumericValue(num[i]);
        }

        return result;
    }

    static string ConvertFromDecimal(int decimalNum, int toBase)
    {
        string result = "";

        while (decimalNum > 0)
        {
            int remainder = decimalNum % toBase;

            if (remainder < 10)
            {
                result = remainder + result;
            }
            else
            {
                result = (char)(remainder - 10 + 'A') + result;
            }

            decimalNum /= toBase;
        }

        return result;
    }
}
