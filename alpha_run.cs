using System;

class Program
{
    static void Main()
    {
        string input = "babad"; // Example input
        string longestPalindrome = FindLongestPalindromicSubstring(input);
        Console.WriteLine($"Longest Palindromic Substring: {longestPalindrome}");
    }

    public static string FindLongestPalindromicSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        int start = 0, maxLength = 1;

        for (int i = 0; i < s.Length; i++)
        {
            // Check for odd length palindromes
            ExpandFromCenter(s, i, i, ref start, ref maxLength);

            // Check for even length palindromes
            ExpandFromCenter(s, i, i + 1, ref start, ref maxLength);
        }

        return s.Substring(start, maxLength);
    }

    private static void ExpandFromCenter(string s, int left, int right, ref int start, ref int maxLength)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            if (right - left + 1 > maxLength)
            {
                start = left;
                maxLength = right - left + 1;
            }
            left--;
            right++;
        }
    }
}