
using System;

class BaseConverter
{
    static void Main()
    {
        Console.WriteLine("Enter the number: ");
        string userInput = Console.ReadLine();

        Console.WriteLine("Enter the current base (2 for binary, 8 for octal, 10 for decimal, 16 for hexadecimal): ");
        int currentBase = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the target base (2 for binary, 8 for octal, 10 for decimal, 16 for hexadecimal): ");
        int targetBase = Convert.ToInt32(Console.ReadLine());

        int decimalNumber = Convert.ToInt32(userInput, currentBase);

        string result = Convert.ToString(decimalNumber, targetBase);

        Console.WriteLine($"The number {userInput} in base {currentBase} is equivalent to {result} in base {targetBase}.");
    }
}
