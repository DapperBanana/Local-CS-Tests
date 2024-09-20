
using System;

class Program
{
    public static string LongestPalindromicSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return "";
        }

        int start = 0;
        int maxLength = 1;

        for (int i = 1; i < s.Length; i++)
        {
            int low = i - 1;
            int high = i;

            // Find the longest even length palindrome with center points i-1 and i
            while (low >= 0 && high < s.Length && s[low] == s[high])
            {
                if (high - low + 1 > maxLength)
                {
                    start = low;
                    maxLength = high - low + 1;
                }
                low--;
                high++;
            }

            low = i - 1;
            high = i + 1;

            // Find the longest odd length palindrome with center point i
            while (low >= 0 && high < s.Length && s[low] == s[high])
            {
                if (high - low + 1 > maxLength)
                {
                    start = low;
                    maxLength = high - low + 1;
                }
                low--;
                high++;
            }
        }

        return s.Substring(start, maxLength);
    }

    static void Main(string[] args)
    {
        string input = "babad";
        string result = LongestPalindromicSubstring(input);
        Console.WriteLine($"The longest palindromic substring in '{input}' is: {result}");
    }
}
