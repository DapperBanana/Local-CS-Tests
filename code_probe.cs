using System;

class Program
{
    // Method to compute the edit distance between two strings
    static int EditDistance(string s1, string s2)
    {
        int m = s1.Length;
        int n = s2.Length;

        // Create a DP array
        int[,] dp = new int[m + 1, n + 1];

        // Initialize the DP array
        for (int i = 0; i <= m; i++)
            dp[i, 0] = i;
        for (int j = 0; j <= n; j++)
            dp[0, j] = j;

        // Fill the DP array
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (s1[i - 1] == s2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = 1 + Math.Min(
                        Math.Min(dp[i - 1, j],    // Deletion
                                 dp[i, j - 1]),   // Insertion
                        dp[i - 1, j - 1]);        // Replacement
                }
            }
        }

        return dp[m, n];
    }

    static void Main(string[] args)
    {
        string str1 = "kitten";
        string str2 = "sitting";

        int distance = EditDistance(str1, str2);
        Console.WriteLine($"Edit distance between '{str1}' and '{str2}' is {distance}");
    }
}