
using System;
using System.Collections.Generic;

class NumberToRomanConverter
{
    public static string ConvertToRoman(int number)
    {
        if (number < 1 || number > 3999)
        {
            return "Number out of range for Roman numerals";
        }

        Dictionary<int, string> romanMap = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        string romanNumeral = "";

        foreach (var kvp in romanMap)
        {
            while (number >= kvp.Key)
            {
                romanNumeral += kvp.Value;
                number -= kvp.Key;
            }
        }

        return romanNumeral;
    }

    static void Main()
    {
        Console.Write("Enter a number to convert to Roman numeral: ");
        int number = Convert.ToInt32(Console.ReadLine());

        string romanNumeral = ConvertToRoman(number);

        Console.WriteLine($"Roman numeral: {romanNumeral}");
    }
}
