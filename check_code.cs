
using System;

class LongestCommonSubsequence
{
    static int[,] LCS(string X, string Y)
    {
        int m = X.Length;
        int n = Y.Length;

        int[,] lcs = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    lcs[i, j] = 0;
                else if (X[i - 1] == Y[j - 1])
                    lcs[i, j] = lcs[i - 1, j - 1] + 1;
                else
                    lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);
            }
        }

        return lcs;
    }

    static string GetLCS(int[,] lcs, string X, string Y)
    {
        int m = X.Length;
        int n = Y.Length;
        string result = "";

        while (m > 0 && n > 0)
        {
            if (X[m - 1] == Y[n - 1])
            {
                result = X[m - 1] + result;
                m--;
                n--;
            }
            else if (lcs[m - 1, n] > lcs[m, n - 1])
                m--;
            else
                n--;
        }

        return result;
    }

    public static void Main()
    {
        string X = "AGGTAB";
        string Y = "GXTXAYB";

        int[,] lcs = LCS(X, Y);
        string result = GetLCS(lcs, X, Y);

        Console.WriteLine("The longest common subsequence is: " + result);
    }
}
