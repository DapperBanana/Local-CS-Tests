
using System;

class EditDistanceCalculator
{
    public static int CalculateEditDistance(string word1, string word2)
    {
        int m = word1.Length;
        int n = word2.Length;

        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            dp[i, 0] = i;
        }

        for (int j = 0; j <= n; j++)
        {
            dp[0, j] = j;
        }

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                int cost = (word1[i - 1] == word2[j - 1]) ? 0 : 1;
                dp[i, j] = Math.Min(Math.Min(dp[i - 1, j] + 1, dp[i, j - 1] + 1), dp[i - 1, j - 1] + cost);
            }
        }

        return dp[m, n];
    }

    static void Main()
    {
        string word1 = "kitten";
        string word2 = "sitting";

        int editDistance = CalculateEditDistance(word1, word2);

        Console.WriteLine($"The edit distance between '{word1}' and '{word2}' is: {editDistance}");
    }
}
