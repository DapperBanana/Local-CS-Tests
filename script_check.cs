
using System;

class RomanToIntegerConverter
{
    static void Main()
    {
        string romanNumeral = "XXIV";
        int result = RomanToInt(romanNumeral);
        
        Console.WriteLine("Roman numeral {0} is equivalent to integer {1}", romanNumeral, result);
    }

    public static int RomanToInt(string s) {
        int result = 0;
        int previousValue = 0;

        foreach(char c in s) {
            int value = GetRomanValue(c);

            if(value > previousValue) {
                result += value - 2 * previousValue;
            } else {
                result += value;
            }

            previousValue = value;
        }

        return result;
    }

    public static int GetRomanValue(char c) {
        switch(c) {
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
}
