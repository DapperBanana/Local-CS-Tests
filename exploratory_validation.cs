
using System;
using System.Collections.Generic;

class RomanToIntegerConverter
{
    public static int RomanToInt(string s)
    {
        Dictionary<char, int> romanToIntMap = new Dictionary<char, int>
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
        int prevValue = 0;
        
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int currValue = romanToIntMap[s[i]];

            if (currValue < prevValue)
            {
                result -= currValue;
            }
            else
            {
                result += currValue;
            }

            prevValue = currValue;
        }

        return result;
    }

    static void Main()
    {
        string romanNumeral = "MCMLXXIV"; // 1974
        int integer = RomanToInt(romanNumeral);
        Console.WriteLine("Roman Numeral: {0}", romanNumeral);
        Console.WriteLine("Integer: {0}", integer);
    }
}
