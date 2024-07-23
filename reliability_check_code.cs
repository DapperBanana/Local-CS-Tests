
using System;

class Program
{
    static string NumberToRoman(int number)
    {
        if (number < 1 || number > 3999)
        {
            throw new ArgumentOutOfRangeException("number", "Number must be between 1 and 3999");
        }

        string[] romanNumerals = new string[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
        int[] arabicValues = new int[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

        string romanNumeral = "";

        for (int i = 12; i >= 0; i--)
        {
            while (number >= arabicValues[i])
            {
                romanNumeral += romanNumerals[i];
                number -= arabicValues[i];
            }
        }

        return romanNumeral;
    }

    static void Main()
    {
        Console.Write("Enter a number (1-3999): ");
        int number = Convert.ToInt32(Console.ReadLine());

        string romanNumeral = NumberToRoman(number);
        Console.WriteLine($"The Roman numeral for {number} is {romanNumeral}");
    }
}
