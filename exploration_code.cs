
using System;

class Program
{
    static int Min(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }

    static int EditDistance(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;

        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0)
                    dp[i, j] = j;
                else if (j == 0)
                    dp[i, j] = i;
                else if (str1[i - 1] == str2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1];
                else
                    dp[i, j] = 1 + Min(dp[i, j - 1], dp[i - 1, j], dp[i - 1, j - 1]);
            }
        }

        return dp[m, n];
    }

    static void Main()
    {
        string str1 = "kitten";
        string str2 = "sitting";

        int distance = EditDistance(str1, str2);
        Console.WriteLine("Edit distance between '{0}' and '{1}' is {2}", str1, str2, distance);
    }
}
