
using System;

class LongestCommonSubsequence
{
    static int[,] memo;

    static int LongestCommonSubsequenceLength(string s1, string s2)
    {
        int m = s1.Length;
        int n = s2.Length;

        memo = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                {
                    memo[i, j] = 0;
                }
                else if (s1[i - 1] == s2[j - 1])
                {
                    memo[i, j] = 1 + memo[i - 1, j - 1];
                }
                else
                {
                    memo[i, j] = Math.Max(memo[i - 1, j], memo[i, j - 1]);
                }
            }
        }

        return memo[m, n];
    }

    static string LongestCommonSubsequenceString(string s1, string s2)
    {
        int i = s1.Length;
        int j = s2.Length;
        string result = "";

        while (i > 0 && j > 0)
        {
            if (s1[i - 1] == s2[j - 1])
            {
                result = s1[i - 1] + result;
                i--;
                j--;
            }
            else if (memo[i - 1, j] > memo[i, j - 1])
            {
                i--;
            }
            else
            {
                j--;
            }
        }

        return result;
    }

    static void Main()
    {
        string s1 = "AGGTAB";
        string s2 = "GXTXAYB";

        int length = LongestCommonSubsequenceLength(s1, s2);
        string sequence = LongestCommonSubsequenceString(s1, s2);

        Console.WriteLine("The length of the longest common subsequence is: " + length);
        Console.WriteLine("The longest common subsequence is: " + sequence);
    }
}
