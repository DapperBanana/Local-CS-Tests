
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        bool isMagicTorus = CheckMagicTorus(matrix);

        if (isMagicTorus)
        {
            Console.WriteLine("Given matrix is a magic torus.");
        }
        else
        {
            Console.WriteLine("Given matrix is not a magic torus.");
        }
    }

    static bool CheckMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int[] rowSums = new int[n];
        int[] colSums = new int[n];

        int diagonalSum1 = 0;
        int diagonalSum2 = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                rowSums[i] += matrix[i, j];
                colSums[j] += matrix[i, j];

                if (i == j)
                {
                    diagonalSum1 += matrix[i, j];
                }

                if (i + j == n - 1)
                {
                    diagonalSum2 += matrix[i, j];
                }
            }
        }

        if (diagonalSum1 != diagonalSum2)
        {
            return false;
        }

        for (int i = 1; i < n; i++)
        {
            if (rowSums[i] != rowSums[0] || colSums[i] != colSums[0])
            {
                return false;
            }
        }

        return true;
    }
}
