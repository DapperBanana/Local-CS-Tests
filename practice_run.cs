
using System;

class Program
{
    static void Main()
    {
        string input = "babad";
        string result = LongestPalindromicSubstring(input);
        Console.WriteLine("Longest Palindromic Substring: " + result);
    }

    static string LongestPalindromicSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";
        
        int maxLen = 0;
        int start = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int len1 = ExpandAroundCenter(s, i, i);
            int len2 = ExpandAroundCenter(s, i, i + 1);
            int len = Math.Max(len1, len2);

            if (len > maxLen)
            {
                maxLen = len;
                start = i - (len - 1) / 2;
            }
        }

        return s.Substring(start, maxLen);
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
