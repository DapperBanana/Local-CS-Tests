
using System;

class BaseConverter
{
    static void Main()
    {
        Console.WriteLine("Enter the number to convert:");
        string number = Console.ReadLine();

        Console.WriteLine("Enter the current base of the number:");
        int currentBase = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the new base to convert to:");
        int newBase = Convert.ToInt32(Console.ReadLine());

        string result = ConvertBase(number, currentBase, newBase);

        Console.WriteLine("Converted number: " + result);
    }

    static string ConvertBase(string number, int currentBase, int newBase)
    {
        int base10 = ConvertToBase10(number, currentBase);
        return ConvertFromBase10(base10, newBase);
    }

    static int ConvertToBase10(string number, int currentBase)
    {
        int result = 0;
        foreach (char digit in number)
        {
            int value = "0123456789ABCDEF".IndexOf(digit);
            result = result * currentBase + value;
        }
        return result;
    }

    static string ConvertFromBase10(int number, int newBase)
    {
        string result = "";
        while (number > 0)
        {
            int remainder = number % newBase;
            result = "0123456789ABCDEF"[remainder] + result;
            number /= newBase;
        }
        return result;
    }
}
