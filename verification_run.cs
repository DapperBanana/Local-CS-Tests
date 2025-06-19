
using System;

class Program
{
    static void Main()
    {
        int num;
        
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Roman numeral: " + ConvertToRoman(num));
    }

    static string ConvertToRoman(int num)
    {
        if (num < 1 || num > 3999)
        {
            return "Invalid number";
        }
        
        string result = "";
        string[] romanNumeral = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] decimalValue = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        for (int i = 0; i < romanNumeral.Length; i++)
        {
            while (num - decimalValue[i] >= 0)
            {
                result += romanNumeral[i];
                num -= decimalValue[i];
            }
        }

        return result;
    }
}
