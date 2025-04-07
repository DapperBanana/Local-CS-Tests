
using System;
using System.Collections.Generic;

class RomanToIntegerConverter
{
    static Dictionary<char, int> romanValues = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public static int ConvertRomanToInteger(string romanNumeral)
    {
        int result = 0;
        
        for(int i = 0; i < romanNumeral.Length; i++)
        {
            int currentValue = romanValues[romanNumeral[i]];
            
            if(i + 1 < romanNumeral.Length && romanValues[romanNumeral[i + 1]] > currentValue)
            {
                result -= currentValue;
            }
            else
            {
                result += currentValue;
            }
        }
        
        return result;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Roman numeral: ");
        string romanNumeral = Console.ReadLine();
        
        int integerVal = ConvertRomanToInteger(romanNumeral);
        
        Console.WriteLine("The integer value of the Roman numeral {0} is: {1}", romanNumeral, integerVal);
    }
}
