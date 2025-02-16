
using System;

class MagicSquareChecker
{
    public static bool IsMagicSquare(int[,] matrix)
    {
        int[] rowSums = new int[matrix.GetLength(0)];
        int[] colSums = new int[matrix.GetLength(1)];
        int diagonalSum1 = 0;
        int diagonalSum2 = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                rowSums[i] += matrix[i, j];
                colSums[j] += matrix[i, j];

                if (i == j)
                {
                    diagonalSum1 += matrix[i, j];
                }

                if (i + j == matrix.GetLength(0) - 1)
                {
                    diagonalSum2 += matrix[i, j];
                }
            }
        }

        bool isMagicSquare = true;
        int targetSum = rowSums[0];

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            if (rowSums[i] != targetSum || colSums[i] != targetSum)
            {
                isMagicSquare = false;
                break;
            }
        }

        if (diagonalSum1 != targetSum || diagonalSum2 != targetSum)
        {
            isMagicSquare = false;
        }

        return isMagicSquare;
    }

    static void Main()
    {
        int[,] matrix = {
            {2, 7, 6},
            {9, 5, 1},
            {4, 3, 8}
        };

        bool result = IsMagicSquare(matrix);

        if (result)
        {
            Console.WriteLine("The matrix is a magic square.");
        }
        else
        {
            Console.WriteLine("The matrix is not a magic square.");
        }
    }
}
