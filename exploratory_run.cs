
using System;

class MagicTorusChecker
{
    static void Main()
    {
        int[,] matrix = {
            { 16, 3, 2, 13 },
            { 5, 10, 11, 8 },
            { 9, 6, 7, 12 },
            { 4, 15, 14, 1 }
        };

        bool isMagicTorus = CheckMagicTorus(matrix);
        Console.WriteLine($"Is the given matrix a magic torus? {isMagicTorus}");
    }

    static bool CheckMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        // Calculate the expected magic sum
        int magicSum = n * (n * n + 1) / 2;

        // Check each row
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += matrix[i, j];
            }
            if (sum != magicSum)
            {
                return false;
            }
        }

        // Check each column
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, j];
            }
            if (sum != magicSum)
            {
                return false;
            }
        }

        // Check the diagonals
        int diagSum1 = 0;
        int diagSum2 = 0;
        for (int i = 0; i < n; i++)
        {
            diagSum1 += matrix[i, i];
            diagSum2 += matrix[i, n - i - 1];
        }
        if (diagSum1 != magicSum || diagSum2 != magicSum)
        {
            return false;
        }

        return true;
    }
}
