
using System;

class MagicSquareChecker
{
    public static bool IsMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        // Calculate sum of first row
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += matrix[0, i];
        }

        // Check sum of all rows
        for (int i = 1; i < n; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
            }
            if (rowSum != sum)
            {
                return false;
            }
        }

        // Check sum of all columns
        for (int j = 0; j < n; j++)
        {
            int colSum = 0;
            for (int i = 0; i < n; i++)
            {
                colSum += matrix[i, j];
            }
            if (colSum != sum)
            {
                return false;
            }
        }

        // Check sum of diagonals
        int diagSum1 = 0;
        int diagSum2 = 0;
        for (int i = 0; i < n; i++)
        {
            diagSum1 += matrix[i, i];
            diagSum2 += matrix[i, n - 1 - i];
        }

        if (diagSum1 != sum || diagSum2 != sum)
        {
            return false;
        }

        return true;
    }

    static void Main()
    {
        int[,] matrix = {
            {2, 7, 6},
            {9, 5, 1},
            {4, 3, 8}
        };

        if (IsMagicSquare(matrix))
        {
            Console.WriteLine("The given matrix is a magic square.");
        }
        else
        {
            Console.WriteLine("The given matrix is not a magic square.");
        }
    }
}
