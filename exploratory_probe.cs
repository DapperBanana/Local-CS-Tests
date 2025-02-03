
using System;

class PalindromeYearChecker
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if (IsPalindrome(year))
        {
            Console.WriteLine($"{year} is a palindrome year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a palindrome year.");
        }
    }

    static bool IsPalindrome(int year)
    {
        string yearStr = year.ToString();
        int length = yearStr.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (yearStr[i] != yearStr[length - i - 1])
                return false;
        }

        return true;
    }
}
