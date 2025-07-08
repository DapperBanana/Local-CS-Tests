
using System;

class Program
{
    static string LongestCommonSubsequence(string str1, string str2)
    {
        int[,] dp = new int[str1.Length + 1, str2.Length + 1];

        for (int i = 1; i <= str1.Length; i++)
        {
            for (int j = 1; j <= str2.Length; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        int length = dp[str1.Length, str2.Length];
        char[] lcs = new char[length];

        int m = str1.Length, n = str2.Length;
        while (m > 0 && n > 0)
        {
            if (str1[m - 1] == str2[n - 1])
            {
                lcs[length - 1] = str1[m - 1];
                m--;
                n--;
                length--;
            }
            else if (dp[m - 1, n] > dp[m, n - 1])
            {
                m--;
            }
            else
            {
                n--;
            }
        }

        return new string(lcs);
    }

    static void Main()
    {
        string str1 = "ABCDGH";
        string str2 = "AEDFHR";

        string lcs = LongestCommonSubsequence(str1, str2);

        Console.WriteLine("Longest Common Subsequence: " + lcs);
    }
}
