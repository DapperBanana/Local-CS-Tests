
using System;

class EditDistanceCalculator
{
    public static int CalculateEditDistance(string s, string t)
    {
        int m = s.Length;
        int n = t.Length;

        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0)
                    dp[i, j] = j;
                else if (j == 0)
                    dp[i, j] = i;
                else if (s[i - 1] == t[j - 1])
                    dp[i, j] = dp[i - 1, j - 1];
                else
                    dp[i, j] = 1 + Math.Min(Math.Min(dp[i, j - 1], dp[i - 1, j]), dp[i - 1, j - 1]);
            }
        }

        return dp[m, n];
    }

    static void Main()
    {
        string s1 = "kitten";
        string s2 = "sitting";

        int result = CalculateEditDistance(s1, s2);

        Console.WriteLine("The edit distance between '{0}' and '{1}' is {2}", s1, s2, result);
    }
}
