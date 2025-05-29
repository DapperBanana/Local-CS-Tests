
using System;

class NumberConverter
{
    // Function to convert a number from one base to another
    public static string ConvertBase(string number, int fromBase, int toBase)
    {
        int decimalValue = Convert.ToInt32(number, fromBase);
        string result = Convert.ToString(decimalValue, toBase);
        return result;
    }

    static void Main()
    {
        Console.Write("Enter the number to convert: ");
        string number = Console.ReadLine();

        Console.Write("Enter the base of the number: ");
        int fromBase = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the base to convert to: ");
        int toBase = Convert.ToInt32(Console.ReadLine());

        string convertedNumber = ConvertBase(number, fromBase, toBase);
        Console.WriteLine("The converted number is: {0}", convertedNumber);
    }
}
