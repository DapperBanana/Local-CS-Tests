
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryNumber = ConvertDecimalToBinary(decimalNumber);
        Console.WriteLine($"Binary representation: {binaryNumber}");
    }

    static string ConvertDecimalToBinary(int decimalNumber)
    {
        string binary = "";
        
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binary = remainder + binary;
            decimalNumber /= 2;
        }

        return binary;
    }
}
