
using System;

class Program
{
    static void Main()
    {
        int number;
        
        Console.WriteLine("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Roman numeral: " + ConvertToRoman(number));
    }
    
    static string ConvertToRoman(int number)
    {
        if (number < 1 || number > 3999)
        {
            return "Number out of range (1-3999)";
        }
        
        string[] romanNumerals = 
        {
            "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"
        };
        
        int[] arabicValues = 
        {
            1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000
        };
        
        string result = "";
        
        for (int i = arabicValues.Length - 1; i >= 0; i--)
        {
            while (number >= arabicValues[i])
            {
                result += romanNumerals[i];
                number -= arabicValues[i];
            }
        }
        
        return result;
    }
}
