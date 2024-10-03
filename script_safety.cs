
using System;
using System.Collections.Generic;

class Program
{
    public static int RomanToInt(string s)
    {
        Dictionary<char, int> romanNumeralValues = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && romanNumeralValues[s[i]] < romanNumeralValues[s[i + 1]])
            {
                result -= romanNumeralValues[s[i]];
            }
            else
            {
                result += romanNumeralValues[s[i]];
            }
        }

        return result;
    }

    static void Main()
    {
        string romanNumeral = "IV";
        int integer = RomanToInt(romanNumeral);
        
        Console.WriteLine("Roman numeral: " + romanNumeral);
        Console.WriteLine("Integer value: " + integer);
    }
}
