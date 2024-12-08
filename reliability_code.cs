
using System;

class Program
{
    static int LongestCommonSubsequence(string s1, string s2)
    {
        int[,] dp = new int[s1.Length + 1, s2.Length + 1];

        for (int i = 0; i <= s1.Length; i++)
        {
            for (int j = 0; j <= s2.Length; j++)
            {
                if (i == 0 || j == 0)
                {
                    dp[i, j] = 0;
                }
                else if (s1[i - 1] == s2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        return dp[s1.Length, s2.Length];
    }

    static void Main()
    {
        string s1 = "ABCBDAB";
        string s2 = "BDCAB";

        int result = LongestCommonSubsequence(s1, s2);

        Console.WriteLine("Length of Longest Common Subsequence: " + result);
    }
}
