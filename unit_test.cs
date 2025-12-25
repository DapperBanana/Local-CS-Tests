using System;

class Program
{
    // Method to find the length of the Longest Common Subsequence (LCS)
    static int LongestCommonSubsequence(string s1, string s2)
    {
        int m = s1.Length;
        int n = s2.Length;
        int[,] dp = new int[m + 1, n + 1];

        // Build the dp matrix from bottom up
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
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

        // The bottom-right cell contains the length of LCS
        return dp[m, n];
    }

    // Method to reconstruct one LCS
    static string GetLongestCommonSubsequence(string s1, string s2)
    {
        int m = s1.Length;
        int n = s2.Length;
        int[,] dp = new int[m + 1, n + 1];

        // Fill the dp matrix
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
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

        // Reconstruct the LCS from the dp matrix
        int index = dp[m, n];
        char[] lcsChars = new char[index];
        int iIndex = m, jIndex = n;

        while (iIndex > 0 && jIndex > 0)
        {
            if (s1[iIndex - 1] == s2[jIndex - 1])
            {
                lcsChars[index - 1] = s1[iIndex - 1];
                iIndex--;
                jIndex--;
                index--;
            }
            else if (dp[iIndex - 1, jIndex] > dp[iIndex, jIndex - 1])
            {
                iIndex--;
            }
            else
            {
                jIndex--;
            }
        }

        return new string(lcsChars);
    }

    static void Main()
    {
        string str1 = "AGGTAB";
        string str2 = "GXTXAYB";

        string lcs = GetLongestCommonSubsequence(str1, str2);
        Console.WriteLine("Longest Common Subsequence: " + lcs);
    }
}