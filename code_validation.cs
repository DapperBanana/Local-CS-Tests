
using System;

class LongestCommonSubsequence
{
    static int LongestCommonSubsequenceLength(string str1, string str2)
    {
        int[,] lcs = new int[str1.Length + 1, str2.Length + 1];

        for (int i = 0; i <= str1.Length; i++)
        {
            for (int j = 0; j <= str2.Length; j++)
            {
                if (i == 0 || j == 0)
                {
                    lcs[i, j] = 0;
                }
                else if (str1[i - 1] == str2[j - 1])
                {
                    lcs[i, j] = lcs[i - 1, j - 1] + 1;
                }
                else
                {
                    lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);
                }
            }
        }

        return lcs[str1.Length, str2.Length];
    }

    static void Main()
    {
        string str1 = "AGGTAB";
        string str2 = "GXTXAYB";

        int length = LongestCommonSubsequenceLength(str1, str2);
        Console.WriteLine("Length of Longest Common Subsequence: " + length);
    }
}
