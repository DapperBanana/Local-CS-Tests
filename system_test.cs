
using System;

class Program
{
    static int LongestCommonSubsequence(string str1, string str2)
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

    static void Main()
    {
        string str1 = "ABCDGH";
        string str2 = "AEDFHR";

        int length = LongestCommonSubsequence(str1, str2);

        string result = "";

        int i = str1.Length;
        int j = str2.Length;

        while (i > 0 && j > 0)
        {
            if (str1[i - 1] == str2[j - 1])
            {
                result = str1[i - 1] + result;
                i--;
                j--;
            }
            else if (dp[i - 1, j] > dp[i, j - 1])
                i--;
            else
                j--;
        }

        Console.WriteLine("The longest common subsequence is: " + result);
    }
}
