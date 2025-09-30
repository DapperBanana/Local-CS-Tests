
using System;

class BaseConverter
{
    static void Main()
    {
        Console.Write("Enter the number to convert: ");
        string number = Console.ReadLine();

        Console.Write("Enter the base it is currently in: ");
        int fromBase = int.Parse(Console.ReadLine());

        Console.Write("Enter the base you want to convert it to: ");
        int toBase = int.Parse(Console.ReadLine());

        int decimalNumber = ConvertToDecimal(number, fromBase);
        string convertedNumber = ConvertFromDecimal(decimalNumber, toBase);

        Console.WriteLine($"Converted number: {convertedNumber}");
    }

    static int ConvertToDecimal(string number, int fromBase)
    {
        int result = 0;
        for (int i = 0; i < number.Length; i++)
        {
            result += (int)Math.Pow(fromBase, i) * int.Parse(number[number.Length - 1 - i].ToString());
        }
        return result;
    }

    static string ConvertFromDecimal(int number, int toBase)
    {
        string result = "";
        while (number > 0)
        {
            result = (number % toBase) + result;
            number /= toBase;
        }
        return result;
    }
}
