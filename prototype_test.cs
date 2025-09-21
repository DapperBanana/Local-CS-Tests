
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose conversion:");
        Console.WriteLine("1. Binary to Decimal");
        Console.WriteLine("2. Decimal to Binary");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter a binary number: ");
                string binary = Console.ReadLine();
                int decimalNumber = ConvertBinaryToDecimal(binary);
                Console.WriteLine($"Decimal: {decimalNumber}");
                break;
            case 2:
                Console.Write("Enter a decimal number: ");
                int decimalNum = int.Parse(Console.ReadLine());
                string binaryNum = ConvertDecimalToBinary(decimalNum);
                Console.WriteLine($"Binary: {binaryNum}");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    static int ConvertBinaryToDecimal(string binary)
    {
        int decimalNumber = 0;
        int power = 0;
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            if (binary[i] == '1')
            {
                decimalNumber += (int)Math.Pow(2, power);
            }
            power++;
        }
        return decimalNumber;
    }

    static string ConvertDecimalToBinary(int decimalNum)
    {
        string binaryNumber = "";
        while (decimalNum > 0)
        {
            binaryNumber = (decimalNum % 2) + binaryNumber;
            decimalNum /= 2;
        }
        return binaryNumber;
    }
}
