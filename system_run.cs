
using System;

class LongestCommonSubsequence
{
    static int LongestCommonSubsequenceLength(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;

        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    dp[i, j] = 0;
                else if (str1[i - 1] == str2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        return dp[m, n];
    }

    static string LongestCommonSubsequenceString(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;
        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    dp[i, j] = 0;
                else if (str1[i - 1] == str2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        int index = dp[m, n];
        char[] lcs = new char[index + 1];
        lcs[index] = '\0';

        int p = m, q = n;
        while (p > 0 && q > 0)
        {
            if (str1[p - 1] == str2[q - 1])
            {
                lcs[index - 1] = str1[p - 1];
                p--;
                q--;
                index--;
            }
            else if (dp[p - 1, q] > dp[p, q - 1])
                p--;
            else
                q--;
        }

        return new string(lcs);
    }

    static void Main()
    {
        string str1 = "AGGTAB";
        string str2 = "GXTXAYB";

        Console.WriteLine("Longest Common Subsequence Length: " + LongestCommonSubsequenceLength(str1, str2));
        Console.WriteLine("Longest Common Subsequence: " + LongestCommonSubsequenceString(str1, str2));
    }
}
