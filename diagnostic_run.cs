
using System;

class LongestCommonSubsequence
{
    static int LongestCommonSubsequenceLength(string str1, string str2)
    {
        int n = str1.Length;
        int m = str2.Length;

        int[,] dp = new int[n + 1, m + 1];

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        return dp[n, m];
    }

    static string LongestCommonSubsequenceString(string str1, string str2)
    {
        int n = str1.Length;
        int m = str2.Length;

        int[,] dp = new int[n + 1, m + 1];

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        int index = dp[n, m];
        char[] lcs = new char[index];

        int a = n, b = m;
        while (a > 0 && b > 0)
        {
            if (str1[a - 1] == str2[b - 1])
            {
                lcs[index - 1] = str1[a - 1];
                a--;
                b--;
                index--;
            }
            else if (dp[a - 1, b] > dp[a, b - 1])
            {
                a--;
            }
            else
            {
                b--;
            }
        }

        return new String(lcs);
    }

    public static void Main()
    {
        string str1 = "AGGTAB";
        string str2 = "GXTXAYB";

        Console.WriteLine("Longest Common Subsequence length: " + LongestCommonSubsequenceLength(str1, str2));
        Console.WriteLine("Longest Common Subsequence: " + LongestCommonSubsequenceString(str1, str2));
    }
}
