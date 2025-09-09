
using System;

class LongestCommonSubsequence
{
    static int[,] LCSLength(string X, string Y)
    {
        int m = X.Length;
        int n = Y.Length;
        int[,] c = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    c[i, j] = 0;
                else if (X[i - 1] == Y[j - 1])
                    c[i, j] = c[i - 1, j - 1] + 1;
                else
                    c[i, j] = Math.Max(c[i - 1, j], c[i, j - 1]);
            }
        }

        return c;
    }

    static string LongestCommonSubsequenceString(string X, string Y)
    {
        int m = X.Length;
        int n = Y.Length;
        int[,] c = LCSLength(X, Y);
        int index = c[m, n];
        char[] lcs = new char[index + 1];
        lcs[index] = '\0';

        int i = m, j = n;
        while (i > 0 && j > 0)
        {
            if (X[i - 1] == Y[j - 1])
            {
                lcs[index - 1] = X[i - 1];
                i--; j--; index--;
            }
            else if (c[i - 1, j] > c[i, j - 1])
            {
                i--;
            }
            else
            {
                j--;
            }
        }

        return new string(lcs).Substring(0, c[m, n]);
    }

    static void Main()
    {
        string X = "ABCBDAB";
        string Y = "BDCAB";
        
        string lcs = LongestCommonSubsequenceString(X, Y);

        Console.WriteLine("Longest Common Subsequence: " + lcs);
    }
}
