
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if(IsPalindromeYear(year))
        {
            Console.WriteLine(year + " is a palindrome year.");
        }
        else
        {
            Console.WriteLine(year + " is not a palindrome year.");
        }
    }

    static bool IsPalindromeYear(int year)
    {
        string yearString = year.ToString();

        for(int i = 0; i < yearString.Length / 2; i++)
        {
            if(yearString[i] != yearString[yearString.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
