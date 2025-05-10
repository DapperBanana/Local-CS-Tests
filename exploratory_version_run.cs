
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNum = int.Parse(Console.ReadLine());

        string binaryNum = ConvertDecimalToBinary(decimalNum);
        Console.WriteLine($"Binary form of {decimalNum} is: {binaryNum}");
    }

    static string ConvertDecimalToBinary(int decimalNum)
    {
        string binaryNum = "";

        while (decimalNum > 0)
        {
            int remainder = decimalNum % 2;
            binaryNum = remainder + binaryNum;
            decimalNum /= 2;
        }

        return binaryNum;
    }
}
