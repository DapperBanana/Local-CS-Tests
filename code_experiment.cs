
using System;

class Program
{
    static int LongestCommonSubsequence(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;

        int[,] LCS = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    LCS[i, j] = 0;
                else if (str1[i - 1] == str2[j - 1])
                    LCS[i, j] = LCS[i - 1, j - 1] + 1;
                else
                    LCS[i, j] = Math.Max(LCS[i - 1, j], LCS[i, j - 1]);
            }
        }

        return LCS[m, n];
    }

    static void Main()
    {
        string str1 = "AGGTAB";
        string str2 = "GXTXAYB";

        int length = LongestCommonSubsequence(str1, str2);

        Console.WriteLine("The length of the longest common subsequence is: " + length);
    }
}
