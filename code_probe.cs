
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a Roman numeral: ");
        string romanNumeral = Console.ReadLine().ToUpper();

        int result = RomanToInteger(romanNumeral);
        Console.WriteLine($"The integer conversion of {romanNumeral} is: {result}");
    }

    static int RomanToInteger(string roman)
    {
        int result = 0;
        int prevValue = 0;

        foreach (char c in roman)
        {
            int value = RomanNumeralValue(c);

            if (value > prevValue)
            {
                result = result + value - 2 * prevValue;
            }
            else
            {
                result += value;
            }

            prevValue = value;
        }

        return result;
    }

    static int RomanNumeralValue(char c)
    {
        switch (c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}
