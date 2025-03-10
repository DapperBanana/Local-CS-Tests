
using System;

class MagicSquareChecker
{
    static void Main()
    {
        int n = 3; // size of the matrix (3x3 for example)
        int[,] matrix = new int[,]
        {
            {2, 7, 6},
            {9, 5, 1},
            {4, 3, 8}
        };

        bool isMagicSquare = CheckMagicSquare(matrix, n);

        if (isMagicSquare)
        {
            Console.WriteLine("The matrix is a magic square.");
        }
        else
        {
            Console.WriteLine("The matrix is not a magic square.");
        }
    }

    static bool CheckMagicSquare(int[,] matrix, int n)
    {
        // Calculate the sum of the first row to use as the benchmark
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += matrix[0, i];
        }

        // Check rows and columns sum
        for (int i = 1; i < n; i++)
        {
            int rowSum = 0;
            int colSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
                colSum += matrix[j, i];
            }

            if (rowSum != sum || colSum != sum)
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
            diag2Sum += matrix[i, n - 1 - i];
        }

        if (diag1Sum != sum || diag2Sum != sum)
        {
            return false;
        }

        return true;
    }
}
