
using System;

class EditDistanceCalculator
{
    public static int EditDistance(string s1, string s2)
    {
        int m = s1.Length;
        int n = s2.Length;

        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0)
                {
                    dp[i, j] = j;
                }
                else if (j == 0)
                {
                    dp[i, j] = i;
                }
                else if (s1[i - 1] == s2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = 1 + Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1]));
                }
            }
        }

        return dp[m, n];
    }

    public static void Main()
    {
        string s1 = "kitten";
        string s2 = "sitting";

        int distance = EditDistance(s1, s2);
        Console.WriteLine("Edit distance between {0} and {1} is {2}", s1, s2, distance);
    }
}
