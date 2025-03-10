
using System;

class EditDistance
{
    static int Min(int a, int b, int c)
    {
        return Math.Min(Math.Min(a, b), c);
    }

    static int EditDist(string str1, string str2, int m, int n)
    {
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

    public static void Main()
    {
        string str1 = "sunday";
        string str2 = "saturday";

        int m = str1.Length;
        int n = str2.Length;

        Console.WriteLine("Edit distance between {0} and {1} is {2}", str1, str2, EditDist(str1, str2, m, n));
    }
}
