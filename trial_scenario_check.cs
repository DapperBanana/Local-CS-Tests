
using System;

class Program
{
    static string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        int start = 0;
        int maxLength = 1;

        for (int i = 0; i < s.Length; i++)
        {
            // Find palindromes with odd length
            int left = i;
            int right = i;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                int length = right - left + 1;
                if (length > maxLength)
                {
                    start = left;
                    maxLength = length;
                }
                left--;
                right++;
            }

            // Find palindromes with even length
            left = i;
            right = i + 1;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                int length = right - left + 1;
                if (length > maxLength)
                {
                    start = left;
                    maxLength = length;
                }
                left--;
                right++;
            }
        }

        return s.Substring(start, maxLength);
    }

    static void Main()
    {
        string input = "babad";
        string result = LongestPalindrome(input);
        Console.WriteLine("Longest palindromic substring in '{0}' is: {1}", input, result);
    }
}
