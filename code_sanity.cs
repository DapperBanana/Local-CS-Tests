
using System;

class MagicSquare
{
    static bool IsMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += matrix[0, i];
        }

        // Check rows
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

        // Check columns
        for (int i = 0; i < n; i++)
        {
            int colSum = 0;
            for (int j = 0; j < n; j++)
            {
                colSum += matrix[j, i];
            }
            if (colSum != sum)
            {
                return false;
            }
        }

        // Check diagonals
        int diag1Sum = 0;
        int diag2Sum = 0;
        for (int i = 0; i < n; i++)
        {
            diag1Sum += matrix[i, i];
            diag2Sum += matrix[i, n - 1 - i];
        }

        if (diag1Sum != sum || diag2Sum != sum)
        {
            return false;
        }

        return true;
    }

    static void Main()
    {
        int[,] matrix = {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 8 }
        };

        if (IsMagicSquare(matrix))
        {
            Console.WriteLine("The matrix is a magic square.");
        }
        else
        {
            Console.WriteLine("The matrix is not a magic square.");
        }
    }
}
