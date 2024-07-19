
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number to convert to binary:");
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryNumber = DecimalToBinary(decimalNumber);

        Console.WriteLine($"The binary representation of {decimalNumber} is: {binaryNumber}");
    }

    static string DecimalToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
            return "0";

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
