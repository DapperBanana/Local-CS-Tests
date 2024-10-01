
using System;

class LongestCommonSubsequence
{
    static int LongestCommonSubsequenceLength(string str1, string str2)
    {
        int[,] dp = new int[str1.Length + 1, str2.Length + 1];

        for (int i = 0; i <= str1.Length; i++)
        {
            for (int j = 0; j <= str2.Length; j++)
            {
                if (i == 0 || j == 0)
                    dp[i, j] = 0;
                else if (str1[i - 1] == str2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        return dp[str1.Length, str2.Length];
    }

    static string LongestCommonSubsequenceString(string str1, string str2)
    {
        int[,] dp = new int[str1.Length + 1, str2.Length + 1];

        for (int i = 0; i <= str1.Length; i++)
        {
            for (int j = 0; j <= str2.Length; j++)
            {
                if (i == 0 || j == 0)
                    dp[i, j] = 0;
                else if (str1[i - 1] == str2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        int index = dp[str1.Length, str2.Length];
        char[] lcs = new char[index];
        int i = str1.Length, j = str2.Length;

        while (i > 0 && j > 0)
        {
            if (str1[i - 1] == str2[j - 1])
            {
                lcs[index - 1] = str1[i - 1];
                i--;
                j--;
                index--;
            }
            else if (dp[i - 1, j] > dp[i, j - 1])
                i--;
            else
                j--;
        }

        return new string(lcs);
    }

    static void Main()
    {
        string str1 = "ABCDGH";
        string str2 = "AEDFHR";

        int length = LongestCommonSubsequenceLength(str1, str2);
        Console.WriteLine("Length of Longest Common Subsequence: " + length);

        string lcs = LongestCommonSubsequenceString(str1, str2);
        Console.WriteLine("Longest Common Subsequence: " + lcs);
    }
}
