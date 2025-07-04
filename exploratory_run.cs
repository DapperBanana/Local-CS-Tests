
using System;

class Program
{
    static string LongestPalindromicSubstring(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";

        int start = 0;
        int maxLength = 1;

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j < s.Length; j++)
            {
                if (IsPalindrome(s, i, j) && j - i + 1 > maxLength)
                {
                    start = i;
                    maxLength = j - i + 1;
                }
            }
        }

        return s.Substring(start, maxLength);
    }

    static bool IsPalindrome(string s, int start, int end)
    {
        while (start < end)
        {
            if (s[start] != s[end])
                return false;

            start++;
            end--;
        }

        return true;
    }

    static void Main()
    {
        string input = "babad";
        string longestPalindrome = LongestPalindromicSubstring(input);

        Console.WriteLine("Longest palindromic substring in '{0}': {1}", input, longestPalindrome);
    }
}
