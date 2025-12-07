using System;

class MagicSquareChecker
{
    static void Main()
    {
        // Example matrix
        int[,] matrix = {
            { 16, 3, 2, 13 },
            { 5, 10, 11, 8 },
            { 9, 6, 7, 12 },
            { 4, 15, 14, 1 }
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

    static bool IsMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        // Check if matrix is square
        if (n != matrix.GetLength(1))
            return false;

        int magicSum = 0;

        // Calculate sum of the first row to set as reference
        for (int j = 0; j < n; j++)
        {
            magicSum += matrix[0, j];
        }

        // Check sums of all rows
        for (int i = 1; i < n; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
            }
            if (rowSum != magicSum)
                return false;
        }

        // Check sums of all columns
        for (int j = 0; j < n; j++)
        {
            int colSum = 0;
            for (int i = 0; i < n; i++)
            {
                colSum += matrix[i, j];
            }
            if (colSum != magicSum)
                return false;
        }

        // Check main diagonal
        int diagSum1 = 0;
        for (int i = 0; i < n; i++)
        {
            diagSum1 += matrix[i, i];
        }
        if (diagSum1 != magicSum)
            return false;

        // Check secondary diagonal
        int diagSum2 = 0;
        for (int i = 0; i < n; i++)
        {
            diagSum2 += matrix[i, n - i - 1];
        }
        if (diagSum2 != magicSum)
            return false;

        return true;
    }
}