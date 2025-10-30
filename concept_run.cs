
using System;

class MagicTorusChecker
{
    static void Main()
    {
        int[][] matrix = new int[][]
        {
            new int[] { 4, 9, 2 },
            new int[] { 3, 5, 7 },
            new int[] { 8, 1, 6 }
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

    static bool IsMagicTorus(int[][] matrix)
    {
        int n = matrix.Length;

        int[] rowSums = new int[n];
        int[] colSums = new int[n];
        int diagSum1 = 0;
        int diagSum2 = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                rowSums[i] += matrix[i][j];
                colSums[j] += matrix[i][j];

                if (i == j)
                {
                    diagSum1 += matrix[i][j];
                }

                if (i + j == n - 1)
                {
                    diagSum2 += matrix[i][j];
                }
            }
        }

        int magicSum = rowSums[0];

        for (int i = 1; i < n; i++)
        {
            if (rowSums[i] != magicSum || colSums[i] != magicSum)
            {
                return false;
            }
        }

        if (diagSum1 != magicSum || diagSum2 != magicSum)
        {
            return false;
        }

        return true;
    }
}
