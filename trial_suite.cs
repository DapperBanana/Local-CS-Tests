
using System;

class MagicTorusChecker
{
    static void Main()
    {
        int[,] matrix = { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } };

        if(IsMagicTorus(matrix))
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
        // Check if the matrix is a square matrix
        if(matrix.GetLength(0) != matrix.GetLength(1))
        {
            return false;
        }

        int n = matrix.GetLength(0);
        int sum = n * (n * n + 1) / 2;

        // Check row sums
        for(int i = 0; i < n; i++)
        {
            int rowSum = 0;
            for(int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
            }
            if(rowSum != sum)
            {
                return false;
            }
        }

        // Check column sums
        for(int j = 0; j < n; j++)
        {
            int colSum = 0;
            for(int i = 0; i < n; i++)
            {
                colSum += matrix[i, j];
            }
            if(colSum != sum)
            {
                return false;
            }
        }

        // Check diagonal sums
        int diagonalSum1 = 0;
        int diagonalSum2 = 0;
        for(int i = 0; i < n; i++)
        {
            diagonalSum1 += matrix[i, i];
            diagonalSum2 += matrix[i, n - 1 - i];
        }
        if(diagonalSum1 != sum || diagonalSum2 != sum)
        {
            return false;
        }

        return true;
    }
}
