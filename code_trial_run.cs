
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number to convert: ");
        string number = Console.ReadLine();

        Console.WriteLine("Enter base of the number: ");
        int fromBase = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter base to convert to: ");
        int toBase = Convert.ToInt32(Console.ReadLine());

        int decimalNumber = ConvertToDecimal(number, fromBase);
        string result = ConvertFromDecimal(decimalNumber, toBase);

        Console.WriteLine($"Converted number: {result}");
    }

    static int ConvertToDecimal(string number, int fromBase)
    {
        return Convert.ToInt32(number, fromBase);
    }

    static string ConvertFromDecimal(int number, int toBase)
    {
        return Convert.ToString(number, toBase);
    }
}
