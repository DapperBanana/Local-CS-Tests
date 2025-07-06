
using System;

class Program
{
    static bool IsMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        int[] sumRows = new int[n];
        int[] sumColumns = new int[n];
        int sumDiagonal1 = 0;
        int sumDiagonal2 = 0;

        for (int i = 0; i < n; i++)
        {
            sumDiagonal1 += matrix[i, i];
            sumDiagonal2 += matrix[i, n - i - 1];

            for (int j = 0; j < n; j++)
            {
                sumRows[i] += matrix[i, j];
                sumColumns[i] += matrix[j, i];
            }
        }

        int magicSum = sumRows[0];

        // Check if the sums are equal
        for (int i = 1; i < n; i++)
        {
            if (sumRows[i] != magicSum || sumColumns[i] != magicSum)
            {
                return false;
            }
        }

        if (sumDiagonal1 != magicSum || sumDiagonal2 != magicSum)
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
            Console.WriteLine("The matrix is a magic square!");
        }
        else
        {
            Console.WriteLine("The matrix is not a magic square.");
        }
    }
}
