
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (IsPalindromeYear(year))
        {
            Console.WriteLine($"{year} is a palindrome year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a palindrome year.");
        }
    }

    static bool IsPalindromeYear(int year)
    {
        string yearString = year.ToString();
        int length = yearString.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (yearString[i] != yearString[length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
