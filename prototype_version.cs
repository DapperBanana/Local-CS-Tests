
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to convert to Roman numeral:");
        int number = Convert.ToInt32(Console.ReadLine());
        
        string romanNumeral = ToRoman(number);
        
        Console.WriteLine($"The Roman numeral for {number} is {romanNumeral}");
    }

    static string ToRoman(int number)
    {
        if (number < 1 || number > 3999)
            throw new ArgumentOutOfRangeException("number", "Input must be between 1 and 3999");

        string[] romanNumerals = {"I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};
        int[] arabicValues = {1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000};

        string result = "";
        for (int i = arabicValues.Length - 1; i >= 0; i--)
        {
            while (number >= arabicValues[i])
            {
                result += romanNumerals[i];
                number -= arabicValues[i];
            }
        }

        return result;
    }
}
