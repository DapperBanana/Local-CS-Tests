
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number to convert:");
        string number = Console.ReadLine();

        Console.WriteLine("Enter the base of the number (2 for binary, 8 for octal, 16 for hexadecimal):");
        int fromBase = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the base to convert to (2 for binary, 8 for octal, 10 for decimal):");
        int toBase = int.Parse(Console.ReadLine());

        int decimalNumber = Convert.ToInt32(number, fromBase);
        string result = Convert.ToString(decimalNumber, toBase);

        Console.WriteLine($"Converted number: {result}");
    }
}
