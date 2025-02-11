
using System;

class Program
{
    static int EditDistance(string str1, string str2)
    {
        int len1 = str1.Length;
        int len2 = str2.Length;

        int[,] dp = new int[len1 + 1, len2 + 1];

        for (int i = 0; i <= len1; i++)
        {
            for (int j = 0; j <= len2; j++)
            {
                if (i == 0)
                    dp[i, j] = j;
                else if (j == 0)
                    dp[i, j] = i;
                else if (str1[i - 1] == str2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1];
                else
                    dp[i, j] = 1 + Math.Min(dp[i, j - 1], Math.Min(dp[i - 1, j], dp[i - 1, j - 1]));
            }
        }

        return dp[len1, len2];
    }

    static void Main()
    {
        string str1 = "kitten";
        string str2 = "sitting";

        int distance = EditDistance(str1, str2);

        Console.WriteLine($"The edit distance between '{str1}' and '{str2}' is: {distance}");
    }
}
