
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = Convert.ToInt32(Console.ReadLine());

        string binaryNumber = ConvertDecimalToBinary(decimalNumber);

        Console.WriteLine($"Binary representation: {binaryNumber}");
    }

    static string ConvertDecimalToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return "0";
        }

        string binaryNumber = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binaryNumber = remainder + binaryNumber;
            decimalNumber /= 2;
        }

        return binaryNumber;
    }
}
