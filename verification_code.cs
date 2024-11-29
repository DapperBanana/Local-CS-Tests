
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to convert to Roman numeral: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 1 || number > 3999)
        {
            Console.WriteLine("Number must be between 1 and 3999.");
            return;
        }

        string result = "";
        string[] romanNumerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] arabicNumerals = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        for (int i = 0; i < arabicNumerals.Length; i++)
        {
            while (number >= arabicNumerals[i])
            {
                result += romanNumerals[i];
                number -= arabicNumerals[i];
            }
        }

        Console.WriteLine($"The Roman numeral is: {result}");
    }
}
