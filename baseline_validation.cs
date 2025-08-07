
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryNumber = ConvertDecimalToBinary(decimalNumber);

        Console.WriteLine($"Binary equivalent: {binaryNumber}");
    }

    static string ConvertDecimalToBinary(int decimalNumber)
    {
        string binaryNumber = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binaryNumber = remainder + binaryNumber;
            decimalNumber = decimalNumber / 2;
        }

        return binaryNumber;
    }
}
