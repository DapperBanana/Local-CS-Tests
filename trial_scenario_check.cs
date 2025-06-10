
using System;

class RomanToIntegerConverter
{
    public static int RomanToInt(string s)
    {
        int total = 0;
        int prevValue = 0;

        foreach(char c in s)
        {
            int value = GetValue(c);

            if(value > prevValue)
            {
                total += value - 2 * prevValue;
            }
            else
            {
                total += value;
            }

            prevValue = value;
        }

        return total;
    }

    public static int GetValue(char c)
    {
        switch(c)
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
                return 0;
        }
    }

    static void Main()
    {
        string romanNumeral = "XIV";
        int result = RomanToInt(romanNumeral);

        Console.WriteLine($"The Roman numeral {romanNumeral} is equal to {result} in integer form.");
    }
}
