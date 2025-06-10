
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Binary representation: " + DecimalToBinary(decimalNumber));
    }

    static string DecimalToBinary(int num)
    {
        if (num == 0)
        {
            return "0";
        }

        string binary = "";

        while (num > 0)
        {
            int remainder = num % 2;
            binary = remainder + binary;
            num = num / 2;
        }

        return binary;
    }
}
