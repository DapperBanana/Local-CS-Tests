
using System;

public class LongestCommonSubsequence
{
    static int[,] LCS(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;

        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                {
                    dp[i, j] = 0;
                }
                else if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        return dp;
    }

    static string GetLCS(string str1, string str2, int[,] dp)
    {
        int m = str1.Length;
        int n = str2.Length;

        string result = "";
        int i = m;
        int j = n;

        while (i > 0 && j > 0)
        {
            if (str1[i - 1] == str2[j - 1])
            {
                result = str1[i - 1] + result;
                i--;
                j--;
            }
            else if (dp[i - 1, j] > dp[i, j - 1])
            {
                i--;
            }
            else
            {
                j--;
            }
        }

        return result;
    }

    public static void Main()
    {
        string str1 = "abcdef";
        string str2 = "acbcf";

        int[,] dp = LCS(str1, str2);

        Console.WriteLine("Longest Common Subsequence: " + GetLCS(str1, str2, dp));
    }
}
