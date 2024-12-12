
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
        int n = s.Length;

        for (int i = 1; i < n; i++)
        {
            // Check for even length palindromes
            int low = i - 1;
            int high = i;
            while (low >= 0 && high < n && s[low] == s[high])
            {
                if (high - low + 1 > maxLength)
                {
                    start = low;
                    maxLength = high - low + 1;
                }
                low--;
                high++;
            }

            // Check for odd length palindromes
            low = i - 1;
            high = i + 1;
            while (low >= 0 && high < n && s[low] == s[high])
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

    static void Main()
    {
        string input = "babad";
        string result = LongestPalindromicSubstring(input);
        Console.WriteLine("Longest palindromic substring in '" + input + "': " + result);
    }
}
