
using System;

class LongestCommonSubsequence
{
    static string LCS(string s1, string s2)
    {
        int[,] dp = new int[s1.Length + 1, s2.Length + 1];
        
        for (int i = 1; i <= s1.Length; i++)
        {
            for (int j = 1; j <= s2.Length; j++)
            {
                if (s1[i - 1] == s2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }
        
        int len = dp[s1.Length, s2.Length];
        char[] lcs = new char[len];
        
        int index = len;
        int p = s1.Length, q = s2.Length;
        
        while (p > 0 && q > 0)
        {
            if (s1[p - 1] == s2[q - 1])
            {
                lcs[index - 1] = s1[p - 1];
                p--;
                q--;
                index--;
            }
            else if (dp[p - 1, q] > dp[p, q - 1])
                p--;
            else
                q--;
        }
        
        return new string(lcs);
    }
    
    static void Main()
    {
        string s1 = "ABCD";
        string s2 = "BD";
        
        string lcs = LCS(s1, s2);
        
        Console.WriteLine("Longest common subsequence: " + lcs);
    }
}
