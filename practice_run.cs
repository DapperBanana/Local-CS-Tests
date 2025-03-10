
using System;

class LongestPalindromicSubstring
{
    static void Main()
    {
        string input = "madamracecarsaabbaa";

        string longestPalindrome = FindLongestPalindromicSubstring(input);

        Console.WriteLine("Longest palindromic substring: " + longestPalindrome);
    }

    static string FindLongestPalindromicSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return "";
        }

        int start = 0;
        int end = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int len1 = ExpandAroundCenter(s, i, i);
            int len2 = ExpandAroundCenter(s, i, i + 1);
            int len = Math.Max(len1, len2);
            if (len > end - start)
            {
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }

        return s.Substring(start, end - start + 1);
    }

    static int ExpandAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return right - left - 1;
    }
}
