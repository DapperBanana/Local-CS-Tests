
using System;

class Program
{
    static bool IsMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int sumRow = 0;
        int sumCol = 0;
        int sumDiag1 = 0;
        int sumDiag2 = 0;

        // Calculate the sum of the first row
        for (int j = 0; j < n; j++)
        {
            sumRow += matrix[0, j];
        }

        // Calculate the sum of the main diagonal
        for (int i = 0; i < n; i++)
        {
            sumDiag1 += matrix[i, i];
        }

        // Calculate the sum of the second diagonal
        for (int i = 0; i < n; i++)
        {
            sumDiag2 += matrix[i, n - i - 1];
        }

        // Check if the sums of rows, columns and diagonals are equal
        if (sumRow != sumDiag1 || sumRow != sumDiag2)
        {
            return false;
        }

        // Check the sum of each row and column
        for (int i = 1; i < n; i++)
        {
            int sumRowTemp = 0;
            int sumColTemp = 0;

            for (int j = 0; j < n; j++)
            {
                sumRowTemp += matrix[i, j];
                sumColTemp += matrix[j, i];
            }

            if (sumRowTemp != sumRow || sumColTemp != sumRow)
            {
                return false;
            }
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
            Console.WriteLine("The given matrix is a magic square.");
        }
        else
        {
            Console.WriteLine("The given matrix is not a magic square.");
        }
    }
}
