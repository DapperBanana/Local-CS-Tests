
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to convert to Roman numeral: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Roman numeral: {ToRoman(number)}");
    }

    static string ToRoman(int number)
    {
        if ((number < 1) || (number > 3999))
            return "Invalid number";

        string[] romanNumeral = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
        int[] romanValue = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

        string result = "";

        for (int i = 12; i >= 0; i--)
        {
            while (number >= romanValue[i])
            {
                result += romanNumeral[i];
                number -= romanValue[i];
            }
        }

        return result;
    }
}
