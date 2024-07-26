
using System;

class LongestCommonSubsequence
{
    static int Max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    static void LongestCommonSubsequenceLength(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;
        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                {
                    dp[i, j] = 0;
                }
                else if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        int index = dp[m, n];
        char[] lcs = new char[index + 1];
        lcs[index] = '\0';

        int x = m, y = n;
        while (x > 0 && y > 0)
        {
            if (str1[x - 1] == str2[y - 1])
            {
                lcs[index - 1] = str1[x - 1];
                x--;
                y--;
                index--;
            }
            else if (dp[x - 1, y] > dp[x, y - 1])
            {
                x--;
            }
            else
            {
                y--;
            }
        }

        Console.WriteLine("The longest common subsequence is: " + new string(lcs));
    }

    static void Main()
    {
        string str1 = "ABCDGH";
        string str2 = "AEDFHR";
        LongestCommonSubsequenceLength(str1, str2);
    }
}
