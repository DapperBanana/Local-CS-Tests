
using System;

class LongestCommonSubsequence
{
    static int[,] memo;

    static string LCS(string s1, string s2, int m, int n)
    {
        if (m == 0 || n == 0)
        {
            return "";
        }

        if (s1[m - 1] == s2[n - 1])
        {
            return LCS(s1, s2, m - 1, n - 1) + s1[m - 1];
        }

        if (memo[m, n - 1] > memo[m - 1, n])
        {
            return LCS(s1, s2, m, n - 1);
        }
        else
        {
            return LCS(s1, s2, m - 1, n);
        }
    }

    static void Main()
    {
        string s1 = "ABCDGH";
        string s2 = "AEDFHR";

        int m = s1.Length;
        int n = s2.Length;

        memo = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                {
                    memo[i, j] = 0;
                }
                else if (s1[i - 1] == s2[j - 1])
                {
                    memo[i, j] = memo[i - 1, j - 1] + 1;
                }
                else
                {
                    memo[i, j] = Math.Max(memo[i - 1, j], memo[i, j - 1]);
                }
            }
        }

        string lcs = LCS(s1, s2, m, n);

        Console.WriteLine("Longest common subsequence: " + lcs);
    }
}
