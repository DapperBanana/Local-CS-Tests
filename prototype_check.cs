
using System;

class BaseConverter
{
    static void Main()
    {
        Console.WriteLine("Enter the number to convert:");
        string inputNumber = Console.ReadLine();

        Console.WriteLine("Enter the base of the input number:");
        int inputBase = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter the base to convert to:");
        int outputBase = Int32.Parse(Console.ReadLine());

        int decimalNumber = ConvertToDecimal(inputNumber, inputBase);
        string outputNumber = ConvertFromDecimal(decimalNumber, outputBase);

        Console.WriteLine($"The number {inputNumber} in base {inputBase} is equal to {outputNumber} in base {outputBase}.");
    }

    static int ConvertToDecimal(string inputNumber, int inputBase)
    {
        int decimalNumber = 0;
        foreach (char c in inputNumber)
        {
            decimalNumber = decimalNumber * inputBase + (c - '0');
        }
        return decimalNumber;
    }

    static string ConvertFromDecimal(int decimalNumber, int outputBase)
    {
        string outputNumber = "";
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % outputBase;
            outputNumber = remainder + outputNumber;
            decimalNumber /= outputBase;
        }
        return outputNumber;
    }
}
