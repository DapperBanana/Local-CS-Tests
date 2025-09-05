
using System;

class EditDistance
{
    static int Min(int a, int b, int c)
    {
        return Math.Min(Math.Min(a, b), c);
    }

    static int CalculateEditDistance(string source, string target)
    {
        int[,] dp = new int[source.Length + 1, target.Length + 1];

        for (int i = 0; i <= source.Length; i++)
        {
            for (int j = 0; j <= target.Length; j++)
            {
                if (i == 0)
                {
                    dp[i, j] = j;
                }
                else if (j == 0)
                {
                    dp[i, j] = i;
                }
                else if (source[i - 1] == target[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = 1 + Min(dp[i - 1, j], dp[i, j - 1], dp[i - 1, j - 1]);
                }
            }
        }

        return dp[source.Length, target.Length];
    }

    static void Main()
    {
        string source = "kitten";
        string target = "sitting";

        int distance = CalculateEditDistance(source, target);

        Console.WriteLine($"Edit distance between '{source}' and '{target}' is: {distance}");
    }
}
