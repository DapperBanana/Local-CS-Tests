
using System;

class EditDistance
{
    static int Min(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }

    static int CalculateEditDistance(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;

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
                else if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = 1 + Min(dp[i - 1, j], dp[i, j - 1], dp[i - 1, j - 1]);
                }
            }
        }

        return dp[m, n];
    }

    static void Main()
    {
        string str1 = "kitten";
        string str2 = "sitting";

        int editDistance = CalculateEditDistance(str1, str2);

        Console.WriteLine($"Edit distance between '{str1}' and '{str2}' is: {editDistance}");
    }
}
