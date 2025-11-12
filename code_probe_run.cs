
using System;

class BaseConverter
{
    static void Main()
    {
        Console.WriteLine("Enter the number to convert:");
        string number = Console.ReadLine();

        Console.WriteLine("Enter the current base of the number:");
        int currentBase = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the base to convert to:");
        int newBase = Convert.ToInt32(Console.ReadLine());

        string result = ConvertBase(number, currentBase, newBase);

        Console.WriteLine($"Converted number: {result}");
    }

    static string ConvertBase(string number, int currentBase, int newBase)
    {
        int decimalNumber = Convert.ToInt32(number, currentBase);
        return Convert.ToString(decimalNumber, newBase);
    }
}
