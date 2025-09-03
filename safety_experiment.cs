
using System;

class LongestCommonSubsequence
{
    static int[,] lcs;

    static string FindLongestCommonSubsequence(string s1, string s2)
    {
        int m = s1.Length;
        int n = s2.Length;
        lcs = new int[m + 1, n + 1];

        // Build the lcs table using dynamic programming
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                {
                    lcs[i, j] = 0;
                }
                else if (s1[i - 1] == s2[j - 1])
                {
                    lcs[i, j] = lcs[i - 1, j - 1] + 1;
                }
                else
                {
                    lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);
                }
            }
        }

        // Find the longest common subsequence by backtracking through the lcs table
        int index = lcs[m, n];
        char[] lcsString = new char[index];
        int iLcs = m, jLcs = n;
        while (iLcs > 0 && jLcs > 0)
        {
            if (s1[iLcs - 1] == s2[jLcs - 1])
            {
                lcsString[index - 1] = s1[iLcs - 1];
                iLcs--;
                jLcs--;
                index--;
            }
            else if (lcs[iLcs - 1, jLcs] > lcs[iLcs, jLcs - 1])
            {
                iLcs--;
            }
            else
            {
                jLcs--;
            }
        }

        return new String(lcsString);
    }

    static void Main()
    {
        string s1 = "ABCDGH";
        string s2 = "AEDFHR";

        string result = FindLongestCommonSubsequence(s1, s2);

        Console.WriteLine("Longest Common Subsequence: " + result);
    }
}
