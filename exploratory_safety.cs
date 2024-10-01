
using System;

class MagicSquareChecker
{
    static bool IsMagicSquare(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Calculate the sum of the main diagonal
        int mainDiagSum = 0;
        for (int i = 0; i < rows; i++)
        {
            mainDiagSum += matrix[i, i];
        }

        // Check if the sums of all the diagonals, rows, and columns are equal
        int secondaryDiagSum = 0;
        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            int colSum = 0;
            for (int j = 0; j < cols; j++)
            {
                rowSum += matrix[i, j];
                colSum += matrix[j, i];
            }
            if (rowSum != mainDiagSum || colSum != mainDiagSum)
            {
                return false;
            }
            secondaryDiagSum += matrix[i, cols - i - 1];
        }

        if (mainDiagSum != secondaryDiagSum)
        {
            return false;
        }

        return true;
    }

    static void Main(string[] args)
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
