
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Binary representation: " + DecimalToBinary(decimalNumber));
    }

    static string DecimalToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
            return "0";

        string binary = "";
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binary = remainder + binary;
            decimalNumber = decimalNumber / 2;
        }

        return binary;
    }
}
