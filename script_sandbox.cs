
using System;

class Program
{
    static string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return "";
        }

        int start = 0;
        int maxLength = 1;

        for (int i = 0; i < s.Length; i++)
        {
            // Odd Length Palindrome
            int left = i;
            int right = i;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                int currentLength = right - left + 1;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    start = left;
                }
                left--;
                right++;
            }

            // Even Length Palindrome
            left = i;
            right = i + 1;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                int currentLength = right - left + 1;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    start = left;
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
        Console.WriteLine("Longest palindrome substring in '{0}' is: {1}", input, result);
    }
}
