
using System;

class MagicSquareChecker
{
    static bool IsMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        // Calculate the sum of the first row
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += matrix[0, j];
        }

        // Check the sum of each row
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

        // Check the sum of each column
        for (int j = 0; j < n; j++)
        {
            int colSum = 0;
            for (int i = 0; i < n; i++)
            {
                colSum += matrix[i, j];
            }

            if (colSum != sum)
            {
                return false;
            }
        }

        // Check the sum of the main diagonal
        int diagSum = 0;
        for (int i = 0; i < n; i++)
        {
            diagSum += matrix[i, i];
        }

        if (diagSum != sum)
        {
            return false;
        }

        // Check the sum of the secondary diagonal
        int secondDiagSum = 0;
        for (int i = 0; i < n; i++)
        {
            secondDiagSum += matrix[i, n - 1 - i];
        }

        if (secondDiagSum != sum)
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
