
using System;

class Program
{
    static int Min(int a, int b, int c)
    {
        return Math.Min(Math.Min(a, b), c);
    }

    static int EditDistance(string str1, string str2)
    {
        int len1 = str1.Length;
        int len2 = str2.Length;

        int[,] dp = new int[len1 + 1, len2 + 1];

        for (int i = 0; i <= len1; i++)
        {
            dp[i, 0] = i;
        }

        for (int j = 0; j <= len2; j++)
        {
            dp[0, j] = j;
        }

        for (int i = 1; i <= len1; i++)
        {
            for (int j = 1; j <= len2; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = 1 + Min(dp[i - 1, j], dp[i, j - 1], dp[i - 1, j - 1]);
                }
            }
        }

        return dp[len1, len2];
    }

    static void Main()
    {
        string str1 = "kitten";
        string str2 = "sitting";

        int distance = EditDistance(str1, str2);

        Console.WriteLine($"The edit distance between \"{str1}\" and \"{str2}\" is {distance}");
    }
}
