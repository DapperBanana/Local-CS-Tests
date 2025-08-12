
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

        Console.WriteLine("Matrix:");
        PrintMatrix(matrix);

        if (IsMagicSquare(matrix))
        {
            Console.WriteLine("The matrix is a magic square.");
        }
        else
        {
            Console.WriteLine("The matrix is not a magic square.");
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool IsMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += matrix[0, i];
        }

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

        int diag1Sum = 0;
        int diag2Sum = 0;

        for (int i = 0; i < n; i++)
        {
            diag1Sum += matrix[i, i];
            diag2Sum += matrix[i, n - 1 - i];
        }

        return diag1Sum == sum && diag2Sum == sum;
    }
}
