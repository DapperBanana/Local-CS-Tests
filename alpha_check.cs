
using System;

class BaseConverter
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter the base of the number:");
        int fromBase = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the target base:");
        int toBase = int.Parse(Console.ReadLine());

        // Convert the input number to decimal
        int decimalNumber = ConvertToDecimal(input, fromBase);

        // Convert the decimal number to the target base
        string result = ConvertFromDecimal(decimalNumber, toBase);

        Console.WriteLine($"The converted number is: {result}");
    }

    static int ConvertToDecimal(string number, int fromBase)
    {
        int result = 0;
        char[] digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        for (int i = number.Length - 1, power = 0; i >= 0; i--, power++)
        {
            int digit = Array.IndexOf(digits, char.ToUpper(number[i]));
            result += digit * (int)Math.Pow(fromBase, power);
        }

        return result;
    }

    static string ConvertFromDecimal(int number, int toBase)
    {
        string result = "";
        char[] digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        while (number > 0)
        {
            int remainder = number % toBase;
            result = digits[remainder] + result;
            number /= toBase;
        }

        return result;
    }
}
