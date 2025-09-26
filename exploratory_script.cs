
using System;

class LongestCommonSubsequence
{
    static int[,] memo;

    static int LCS(string s1, string s2)
    {
        int m = s1.Length;
        int n = s2.Length;

        memo = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    memo[i, j] = 0;
                else if (s1[i - 1] == s2[j - 1])
                    memo[i, j] = memo[i - 1, j - 1] + 1;
                else
                    memo[i, j] = Math.Max(memo[i - 1, j], memo[i, j - 1]);
            }
        }

        return memo[m, n];
    }

    static string GetLCS(string s1, string s2)
    {
        int m = s1.Length;
        int n = s2.Length;
        int len = LCS(s1, s2);

        char[] lcs = new char[len];

        int i = m, j = n;
        while (i > 0 && j > 0)
        {
            if (s1[i - 1] == s2[j - 1])
            {
                lcs[len - 1] = s1[i - 1];
                i--;
                j--;
                len--;
            }
            else if (memo[i - 1, j] > memo[i, j - 1])
                i--;
            else
                j--;
        }

        return new string(lcs);
    }

    static void Main()
    {
        string s1 = "abcdaf";
        string s2 = "acbcf";

        string lcs = GetLCS(s1, s2);

        Console.WriteLine("Longest Common Subsequence: " + lcs);
    }
}
