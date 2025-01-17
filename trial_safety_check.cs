
using System;

class BaseConverter
{
    static void Main()
    {
        Console.WriteLine("Enter the number you want to convert: ");
        string number = Console.ReadLine();

        Console.WriteLine("Enter the base of the number you entered (2 for binary, 8 for octal, 10 for decimal, 16 for hexadecimal): ");
        int originalBase = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the base you want to convert the number to (2, 8, 10, or 16): ");
        int newBase = int.Parse(Console.ReadLine());

        string result = ConvertBase(number, originalBase, newBase);

        Console.WriteLine($"The number {number} in base {originalBase} is equal to {result} in base {newBase}.");
    }

    static string ConvertBase(string number, int originalBase, int newBase)
    {
        int base10 = ConvertToBase10(number, originalBase);

        return ConvertFromBase10(base10, newBase);
    }

    static int ConvertToBase10(string number, int originalBase)
    {
        int result = 0;
        for (int i = 0; i < number.Length; i++)
        {
            result += int.Parse(number[i].ToString()) * (int)Math.Pow(originalBase, number.Length - 1 - i);
        }
        return result;
    }

    static string ConvertFromBase10(int number, int newBase)
    {
        string result = "";
        while (number > 0)
        {
            int remainder = number % newBase;
            result = remainder + result;
            number /= newBase;
        }
        return result;
    }
}
