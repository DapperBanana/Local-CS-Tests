
using System;

class MainClass {
    public static void Main (string[] args) {
        string input = "banana";
        string result = LongestPalindrome(input);
        Console.WriteLine("Longest palindromic substring: " + result);
    }

    public static string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) {
            return "";
        }

        int start = 0;
        int maxLength = 1;

        for (int i = 0; i < s.Length; i++) {
            // Check for odd length palindromes
            int l = i;
            int r = i;
            while (l >= 0 && r < s.Length && s[l] == s[r]) {
                if (r - l + 1 > maxLength) {
                    start = l;
                    maxLength = r - l + 1;
                }
                l--;
                r++;
            }

            // Check for even length palindromes
            l = i;
            r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r]) {
                if (r - l + 1 > maxLength) {
                    start = l;
                    maxLength = r - l + 1;
                }
                l--;
                r++;
            }
        }

        return s.Substring(start, maxLength);
    }
}
