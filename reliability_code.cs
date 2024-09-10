
using System;

class MagicTorusChecker
{
    static bool IsMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        
        int[] rowSums = new int[n];
        int[] colSums = new int[n];
        int diagSum1 = 0;
        int diagSum2 = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                rowSums[i] += matrix[i, j];
                colSums[j] += matrix[i, j];
                if (i == j)
                {
                    diagSum1 += matrix[i, j];
                }
                if (i + j == n - 1)
                {
                    diagSum2 += matrix[i, j];
                }
            }
        }

        int magicNumber = rowSums[0];

        for (int i = 1; i < n; i++)
        {
            if (rowSums[i] != magicNumber ||
                colSums[i] != magicNumber)
            {
                return false;
            }
        }

        if (diagSum1 != magicNumber || diagSum2 != magicNumber)
        {
            return false;
        }

        return true;
    }

    static void Main()
    {
        int[,] matrix = new int[,]
        {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 8 }
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
}
