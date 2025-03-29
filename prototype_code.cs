
using System;

class Program
{
    public static int LongestCommonSubsequenceLength(string str1, string str2)
    {
        int[,] dp = new int[str1.Length + 1, str2.Length + 1];
        
        for (int i = 1; i <= str1.Length; i++)
        {
            for (int j = 1; j <= str2.Length; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }
        
        return dp[str1.Length, str2.Length];
    }
    
    static void Main()
    {
        string str1 = "ABCBDAB";
        string str2 = "BDCAB";
        
        int result = LongestCommonSubsequenceLength(str1, str2);
        
        Console.WriteLine($"Length of longest common subsequence: {result}");
    }
}
