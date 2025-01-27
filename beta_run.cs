
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it is a palindrome:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

    static bool IsPalindrome(string str)
    {
        string cleanStr = "";
        foreach (char c in str)
        {
            if (Char.IsLetterOrDigit(c))
            {
                cleanStr += c.ToString().ToLower();
            }
        }

        int left = 0;
        int right = cleanStr.Length - 1;
        
        while (left < right)
        {
            if (cleanStr[left] != cleanStr[right])
            {
                return false;
            }
            
            left++;
            right--;
        }

        return true;
    }
}
