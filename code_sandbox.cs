
using System;

class MagicSquareChecker
{
    static void Main()
    {
        int[,] matrix = {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 8 }
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

    static bool IsMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int magicSum = n * (n * n + 1) / 2;

        // Check rows
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += matrix[i, j];
            }
            if (sum != magicSum)
            {
                return false;
            }
        }

        // Check columns
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, j];
            }
            if (sum != magicSum)
            {
                return false;
            }
        }

        // Check diagonals
        int sumDiagonal1 = 0;
        int sumDiagonal2 = 0;
        for (int i = 0; i < n; i++)
        {
            sumDiagonal1 += matrix[i, i];
            sumDiagonal2 += matrix[i, n - 1 - i];
        }
        if (sumDiagonal1 != magicSum || sumDiagonal2 != magicSum)
        {
            return false;
        }

        return true;
    }
}
