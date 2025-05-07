
using System;

class MagicTorusChecker
{
    static bool IsMagicTorus(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        // Check rows
        int rowSum = 0;
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += matrix[i, j];
            }
            if (rowSum == 0)
            {
                rowSum = sum;
            }
            else if (rowSum != sum)
            {
                return false;
            }
        }

        // Check columns
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += matrix[j, i];
            }
            if (rowSum != sum)
            {
                return false;
            }
        }

        // Check diagonals
        int diagonalSum1 = 0;
        int diagonalSum2 = 0;
        for (int i = 0; i < n; i++)
        {
            diagonalSum1 += matrix[i, i];
            diagonalSum2 += matrix[i, n - i - 1];
        }
        if (rowSum != diagonalSum1 || rowSum != diagonalSum2)
        {
            return false;
        }

        return true;
    }

    static void Main()
    {
        int[,] matrix = {
            { 4, 9, 2 },
            { 3, 5, 7 },
            { 8, 1, 6 }
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
