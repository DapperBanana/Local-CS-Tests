
using System;

class LongestCommonSubsequence
{
    static int[,] memo;

    static string FindLCS(string str1, string str2)
    {
        int n = str1.Length;
        int m = str2.Length;

        memo = new int[n + 1, m + 1];

        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= m; j++)
            {
                if (i == 0 || j == 0)
                    memo[i, j] = 0;
                else if (str1[i - 1] == str2[j - 1])
                    memo[i, j] = memo[i - 1, j - 1] + 1;
                else
                    memo[i, j] = Math.Max(memo[i - 1, j], memo[i, j - 1]);
            }
        }

        int length = memo[n, m];
        char[] lcs = new char[length + 1];
        lcs[length] = '\0';

        int index1 = n, index2 = m;
        while (index1 > 0 && index2 > 0)
        {
            if (str1[index1 - 1] == str2[index2 - 1])
            {
                lcs[length - 1] = str1[index1 - 1];
                index1--;
                index2--;
                length--;
            }
            else if (memo[index1 - 1, index2] > memo[index1, index2 - 1])
            {
                index1--;
            }
            else
            {
                index2--;
            }
        }

        return new string(lcs);
    }

    static void Main(string[] args)
    {
        string str1 = "abcde";
        string str2 = "ace";

        string lcs = FindLCS(str1, str2);

        Console.WriteLine("Longest Common Subsequence: " + lcs);
    }
}
