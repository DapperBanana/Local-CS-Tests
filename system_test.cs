
using System;

class BaseConverter
{
    static long ConvertToDecimal(string number, int sourceBase)
    {
        long result = 0;
        foreach (char digit in number)
        {
            result = result * sourceBase + (long)Char.GetNumericValue(digit);
        }
        return result;
    }

    static string ConvertFromDecimal(long number, int targetBase)
    {
        string result = "";

        while (number > 0)
        {
            long remainder = number % targetBase;
            result = Char.ToUpper((remainder < 10) ? (char)(remainder + '0') : (char)(remainder + 'A' - 10)) + result;
            number /= targetBase;
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter the number to convert: ");
        string number = Console.ReadLine();

        Console.Write("Enter the base of the number: ");
        int sourceBase = int.Parse(Console.ReadLine());

        Console.Write("Enter the target base: ");
        int targetBase = int.Parse(Console.ReadLine());

        long decimalNumber = ConvertToDecimal(number, sourceBase);
        string result = ConvertFromDecimal(decimalNumber, targetBase);

        Console.WriteLine($"The number {number} in base {sourceBase} is equal to {result} in base {targetBase}");
    }
}
