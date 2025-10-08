
using System;

public class RomanToIntegerConverter
{
    public static int RomanToInteger(string romanNumeral)
    {
        if (string.IsNullOrWhiteSpace(romanNumeral))
        {
            throw new ArgumentException("Input cannot be null or empty.");
        }

        int result = 0;
        int prevValue = 0;

        foreach (char numeral in romanNumeral)
        {
            int value = RomanNumeralValue(numeral);

            result += value;

            if (value > prevValue)
            {
                result -= 2 * prevValue;
            }

            prevValue = value;
        }

        return result;
    }

    private static int RomanNumeralValue(char numeral)
    {
        switch (numeral)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                throw new ArgumentException($"Invalid Roman numeral: {numeral}");
        }
    }

    public static void Main()
    {
        string romanNumeral = "MCMLXXXIV"; // 1984 in Roman numerals
        int integer = RomanToInteger(romanNumeral);
        
        Console.WriteLine($"{romanNumeral} in Roman numerals is equal to {integer} in integer form.");
    }
}
