
using System;

class EditDistanceCalculator
{
    public static int CalculateEditDistance(string str1, string str2)
    {
        int[,] dp = new int[str1.Length + 1, str2.Length + 1];

        for (int i = 0; i <= str1.Length; i++)
        {
            dp[i, 0] = i;
        }

        for (int j = 0; j <= str2.Length; j++)
        {
            dp[0, j] = j;
        }

        for (int i = 1; i <= str1.Length; i++)
        {
            for (int j = 1; j <= str2.Length; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = 1 + Math.Min(Math.Min(dp[i, j - 1], dp[i - 1, j]), dp[i - 1, j - 1]);
                }
            }
        }

        return dp[str1.Length, str2.Length];
    }

    static void Main()
    {
        string str1 = "kitten";
        string str2 = "sitting";

        int editDistance = CalculateEditDistance(str1, str2);

        Console.WriteLine("The edit distance between '{0}' and '{1}' is: {2}", str1, str2, editDistance);
    }
}
