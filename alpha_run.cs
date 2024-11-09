
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a Roman numeral: ");
        string romanNumeral = Console.ReadLine();

        Console.WriteLine($"The integer value of {romanNumeral} is {RomanToInteger(romanNumeral)}");
    }

    static int RomanToInteger(string s)
    {
        Dictionary<char, int> romanValues = new Dictionary<char, int>()
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
            int currValue = romanValues[s[i]];

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
}
