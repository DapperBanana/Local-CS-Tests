
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a Roman numeral: ");
        string romanNumeral = Console.ReadLine().ToUpper();

        int result = RomanToInteger(romanNumeral);

        Console.WriteLine($"Integer equivalent of {romanNumeral} is: {result}");
    }

    static int RomanToInteger(string romanNumeral)
    {
        Dictionary<char, int> romanMap = new Dictionary<char, int>
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
        int previousValue = 0;

        foreach (char c in romanNumeral)
        {
            int currentValue = romanMap[c];

            if (currentValue > previousValue)
            {
                result += currentValue - 2 * previousValue;
            }
            else
            {
                result += currentValue;
            }

            previousValue = currentValue;
        }

        return result;
    }
}
