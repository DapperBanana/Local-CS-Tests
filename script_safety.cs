
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

        if (IsMagicTorus(matrix))
        {
            Console.WriteLine("The given matrix is a magic torus.");
        }
        else
        {
            Console.WriteLine("The given matrix is not a magic torus.");
        }
    }

    static bool IsMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int magicSum = n * (n * n + 1) / 2;

        // Check rows
        for (int i = 0; i < n; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
            }
            if (rowSum != magicSum)
            {
                return false;
            }
        }

        // Check columns
        for (int j = 0; j < n; j++)
        {
            int colSum = 0;
            for (int i = 0; i < n; i++)
            {
                colSum += matrix[i, j];
            }
            if (colSum != magicSum)
            {
                return false;
            }
        }

        // Check diagonals
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
