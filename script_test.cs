
using System;

class BaseConverter
{
    static void Main()
    {
        Console.Write("Enter the number to convert: ");
        string numberString = Console.ReadLine();

        Console.Write("Enter the base of the number: ");
        int baseFrom = int.Parse(Console.ReadLine());

        Console.Write("Enter the base to convert to: ");
        int baseTo = int.Parse(Console.ReadLine());

        int result = ConvertToDecimal(numberString, baseFrom);

        string convertedResult = ConvertFromDecimal(result, baseTo);

        Console.WriteLine($"The converted number is: {convertedResult}");
    }

    static int ConvertToDecimal(string numberString, int baseFrom)
    {
        int result = 0;
        for (int i = 0; i < numberString.Length; i++)
        {
            int digit = Char.GetNumericValue(numberString[i]);
            result += (int)(digit * Math.Pow(baseFrom, numberString.Length - 1 - i));
        }
        return result;
    }

    static string ConvertFromDecimal(int number, int baseTo)
    {
        string result = "";
        while (number > 0)
        {
            int remainder = number % baseTo;
            result = remainder + result;
            number /= baseTo;
        }
        return result;
    }
}
