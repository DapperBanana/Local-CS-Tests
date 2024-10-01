
using System;

class BaseConverter
{
    // Function to convert a number from one base to another
    static int ConvertBase(string number, int fromBase, int toBase)
    {
        int decimalNumber = Convert.ToInt32(number, fromBase);
        string result = Convert.ToString(decimalNumber, toBase);

        return Int32.Parse(result);
    }

    static void Main()
    {
        Console.WriteLine("Enter the number to convert: ");
        string number = Console.ReadLine();

        Console.WriteLine("Enter the base of the input number: ");
        int fromBase = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter the base to convert to: ");
        int toBase = Int32.Parse(Console.ReadLine());

        int result = ConvertBase(number, fromBase, toBase);

        Console.WriteLine($"Converted number: {result}");
    }
}
