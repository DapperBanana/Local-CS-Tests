
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

        Console.WriteLine("Checking if the matrix is a magic square:");
        PrintMatrix(matrix);

        bool isMagic = IsMagicSquare(matrix);
        Console.WriteLine("Is it a magic square? " + isMagic);
    }

    static bool IsMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int sum = 0;

        // Calculate the sum of the first row
        for (int col = 0; col < n; col++)
        {
            sum += matrix[0, col];
        }

        // Check rows sum
        for (int row = 1; row < n; row++)
        {
            int rowSum = 0;
            for (int col = 0; col < n; col++)
            {
                rowSum += matrix[row, col];
            }

            if (rowSum != sum)
            {
                return false;
            }
        }

        // Check cols sum
        for (int col = 0; col < n; col++)
        {
            int colSum = 0;
            for (int row = 0; row < n; row++)
            {
                colSum += matrix[row, col];
            }

            if (colSum != sum)
            {
                return false;
            }
        }

        // Check diagonals sum
        int diag1Sum = 0;
        int diag2Sum = 0;
        for (int i = 0; i < n; i++)
        {
            diag1Sum += matrix[i, i];
            diag2Sum += matrix[i, n - i - 1];
        }

        if (diag1Sum != sum || diag2Sum != sum)
        {
            return false;
        }

        return true;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
