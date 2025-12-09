using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to convert to a Roman numeral:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0 && number < 4000)
            {
                Console.WriteLine($"Roman numeral: {ToRoman(number)}");
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 3999.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static string ToRoman(int num)
    {
        string[] thousands = { "", "M", "MM", "MMM" };
        string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        string roman = "";
        roman += thousands[num / 1000];
        roman += hundreds[(num % 1000) / 100];
        roman += tens[(num % 100) / 10];
        roman += units[num % 10];

        return roman;
    }
}