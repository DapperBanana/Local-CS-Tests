
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (IsPalindromeYear(year))
        {
            Console.WriteLine($"{year} is a palindrome year!");
        }
        else
        {
            Console.WriteLine($"{year} is not a palindrome year.");
        }
    }

    static bool IsPalindromeYear(int year)
    {
        string yearString = year.ToString();
        string reversedYearString = "";

        for (int i = yearString.Length - 1; i >= 0; i--)
        {
            reversedYearString += yearString[i];
        }

        return yearString == reversedYearString;
    }
}
